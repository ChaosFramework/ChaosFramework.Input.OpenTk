using System;
using ChaosFramework.Collections.Immutable;
using ChaosUtil.Reflection;
using OpenTK.Windowing.GraphicsLibraryFramework;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;

namespace ChaosFramework.Input.OpenTk
{
    public unsafe sealed partial class OpenTkMouse
        : Mouse
        , StateTracker<Vector2>
    {
        internal class Implementation(OpenTkMouse parent, int index)
            : OpenTkDeviceImplementation<OpenTkMouse, Vector2>(parent, index)
            ;

        readonly TrackedState<Vector2> state = new();
        TrackedState<Vector2> StateTracker<Vector2>.state => state;

        Vector2 StateTracker<Vector2>.GetImmediate(int index)
        {
            GLFW.GetCursorPos(deviceHost.window.WindowPtr, out double x, out double y);
            return new Vector2((float)x, (float)y);
        }

        readonly GLFWCallbacks.MouseButtonCallback buttonCallback;
        readonly DeviceHost deviceHost;
        public OpenTkMouse(DeviceHost deviceHost)
            : base(deviceHost.context)
        {
            this.deviceHost = deviceHost;
            GLFW.SetMouseButtonCallback(deviceHost.window.WindowPtr, buttonCallback = ButtonCallback);
            deviceHost.window.MouseWheel += WheelCallback;
        }

        public override void AdvanceFrame()
        {
            base.AdvanceFrame();
            state.AdvanceFrame();
        }

        protected override Mouse.Position GenerateAxis(Direction direction)
            => new Position(this, direction);

        protected override ImmutableArray<Mouse.Button> GenerateButtons()
            => Array.ConvertAll(Enum<MouseButton>.GetValues(), GenerateButton);

        protected override Mouse.Wheel GenerateWheel(WheelDirection dir)
            => new Wheel(this, dir);

        public override bool IsConnected()
            => true; // TODO

        Button GenerateButton(MouseButton tkButton)
            => new Button(this, tkButton);

        void ButtonCallback(Window* window, MouseButton button, InputAction action, KeyModifiers mods)
            => ((Button)buttons[(int)button]).SetDown(action != InputAction.Release);

        void WheelCallback(MouseWheelEventArgs args)
        {
            if(args.OffsetX != 0) ((Wheel)tilt).SetValue(args.OffsetX);
            if(args.OffsetY != 0) ((Wheel)scroll).SetValue(args.OffsetY);
        }
    }
}

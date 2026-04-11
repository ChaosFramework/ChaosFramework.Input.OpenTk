using System;
using ChaosFramework.Collections.Immutable;
using ChaosUtil.Reflection;
using OpenTK.Input;

namespace ChaosFramework.Input.OpenTk
{
    public sealed partial class OpenTkMouse(InputContext parent)
        : Mouse(parent)
        , StateTracker<MouseState>
    {
        internal class Implementation(OpenTkMouse parent, int index)
            : OpenTkDeviceImplementation<OpenTkMouse, MouseState>(parent, index)
            ;

        readonly TrackedState<MouseState> state = new();
        TrackedState<MouseState> StateTracker<MouseState>.state => state;

        MouseState StateTracker<MouseState>.GetImmediate(int index)
            => OpenTK.Input.Mouse.GetState(index);

        protected override Mouse.Position GenerateAxis(Direction direction)
            => new Position(this, direction);

        protected override ImmutableArray<Mouse.Button> GenerateButtons()
        {
            Button[] arr = Array.ConvertAll(Enum<OpenTK.Input.MouseButton>.GetValues(), GenerateButton);
            // OpenTK swaps the semantics of the "middle" and "right" mouse buttons - so we need to swap it back
            (arr[1], arr[2]) = (arr[2], arr[1]);
            return arr;
        }

        public override void AdvanceFrame()
        {
            base.AdvanceFrame();
            state.AdvanceFrame();
        }

        public override bool IsConnected()
            => state.consistent.IsConnected;

        Button GenerateButton(OpenTK.Input.MouseButton tkButton)
            => new Button(this, tkButton);
    }
}

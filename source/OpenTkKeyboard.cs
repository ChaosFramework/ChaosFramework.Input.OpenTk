using OpenTK.Windowing.GraphicsLibraryFramework;
using System;

namespace ChaosFramework.Input.OpenTk
{
    public unsafe sealed partial class OpenTkKeyboard
        : Keyboard
    {
        readonly GLFWCallbacks.KeyCallback keyCallback;

        public OpenTkKeyboard(DeviceHost deviceHost)
            : base(deviceHost.context)
        {
            GLFW.SetKeyCallback(deviceHost.window.WindowPtr, keyCallback = KeyCallback);
        }

        public override bool IsConnected()
            => true; // TODO

        protected override Keyboard.Key GenerateKey(HidUsage hidUsage)
            => new Key(this, hidUsage);

        void KeyCallback(Window* wnd, Keys key, int scanCode, InputAction action, KeyModifiers mod)
        {
            if (Key.tk2Hid.TryGetValue(key, out HidUsage hid) && hid != HidUsage.Unknown)
                ((Key)this[hid]).SetDown(action switch
                {
                    InputAction.Press => true,
                    InputAction.Repeat => true,
                    InputAction.Release => false,
                    _ => throw new InvalidOperationException()
                });
        }
    }
}

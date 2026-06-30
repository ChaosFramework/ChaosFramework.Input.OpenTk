using OpenTK.Windowing.GraphicsLibraryFramework;

namespace ChaosFramework.Input.OpenTk
{
    using Axis;

    partial class OpenTkController
    {
        private class Button(InputDevice parent, Buttons tkButton)
            : ButtonAxis(parent)
            , OpenTkAxisImplementation<GamepadState>
        {
            readonly Buttons tkButton = tkButton;

            public override string GetAxisString()
                => $"Controller Button {tkButton}";

            void OpenTkAxisImplementation<GamepadState>.CreateEvents(GamepadState newState)
                => SetDown<Button>(MapButtonState(newState, tkButton) != InputAction.Release);
        }
    }
}

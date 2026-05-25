using OpenTK.Input;

namespace ChaosFramework.Input.OpenTk
{
    using Axis;
    partial class OpenTkController
    {
        private class Button(InputDevice parent, Buttons tkButton)
            : ButtonAxis(parent)
            , OpenTkAxisImplementation<GamePadState>
        {
            readonly Buttons tkButton = tkButton;

            public override string GetAxisString()
                => $"Controller Button {tkButton}";

            void OpenTkAxisImplementation<GamePadState>.CreateEvents(GamePadState newState)
                => SetDown<Button>(MapButtonState(newState, tkButton) == ButtonState.Pressed);
        }
    }
}

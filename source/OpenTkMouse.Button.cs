using OpenTK.Input;

namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkMouse
    {
        public new class Button(Mouse parent, MouseButton button)
            : Mouse.Button(parent, Tk2Chaos(button))
            , OpenTkAxisImplementation<MouseState>
        {
            static ButtonSemantic Tk2Chaos(MouseButton tkButton)
                => tkButton switch
                {
                    MouseButton.Left => (ButtonSemantic)ButtonSemantic.Left,
                    MouseButton.Right => (ButtonSemantic)ButtonSemantic.Right,
                    MouseButton.Middle => (ButtonSemantic)ButtonSemantic.Middle,
                    _ => (ButtonSemantic)tkButton,
                };

            public readonly MouseButton tkButton = button;

            void OpenTkAxisImplementation<MouseState>.CreateEvents(MouseState newState)
                => SetDown<Button>(newState.IsButtonDown(tkButton));
        }
    }
}

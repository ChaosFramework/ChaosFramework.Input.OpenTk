
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkMouse
    {
        public new class Button(Mouse parent, MouseButton button)
            : Mouse.Button(parent, Tk2Chaos(button))
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

            public void SetDown(bool down)
                => SetDown<Button>(down);
        }
    }
}

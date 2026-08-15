
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkMouse
    {
        public new class Button(Mouse parent, ButtonSemantic button)
            : Mouse.Button(parent, button)
        {
            internal static ButtonSemantic Tk2Chaos(MouseButton tkButton)
                => tkButton switch
                {
                    MouseButton.Left => ButtonSemantic.Left,
                    MouseButton.Right => ButtonSemantic.Right,
                    MouseButton.Middle => ButtonSemantic.Middle,
                    _ => (ButtonSemantic)tkButton,
                };

            public void SetDown(bool down)
                => SetDown<Button>(down);
        }
    }
}

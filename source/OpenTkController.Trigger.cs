using OpenTK.Windowing.GraphicsLibraryFramework;

namespace ChaosFramework.Input.OpenTk
{
    using Axis;

    partial class OpenTkController
    {
        private class Trigger(InputDevice parent, bool left)
            : BoundedValueAxis(parent)
            , OpenTkAxisImplementation<GamepadState>
        {
            readonly bool left = left;

            public override string GetAxisString()
                => $"Controller {(left ? "L" : "R")}-Trigger";

            unsafe void OpenTkAxisImplementation<GamepadState>.CreateEvents(GamepadState newState)
                => SetValue<Trigger>(left ? newState.Axes[4] : newState.Axes[5]);
        }
    }
}

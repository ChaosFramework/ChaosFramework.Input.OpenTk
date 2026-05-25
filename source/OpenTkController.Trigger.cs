using OpenTK.Input;

namespace ChaosFramework.Input.OpenTk
{
    using Axis;
    partial class OpenTkController
    {
        private class Trigger(InputDevice parent, bool left)
            : BoundedValueAxis(parent)
            , OpenTkAxisImplementation<GamePadState>
        {
            readonly bool left = left;

            public override string GetAxisString()
                => $"Controller {(left ? "L" : "R")}-Trigger";

            void OpenTkAxisImplementation<GamePadState>.CreateEvents(GamePadState newState)
                => SetValue<Trigger>(left ? newState.Triggers.Left : newState.Triggers.Right);
        }
    }
}

using OpenTK;
using OpenTK.Input;

namespace ChaosFramework.Input.OpenTk
{
    using Axis;
    partial class OpenTkController
    {
        private class Stick
            : AxisArea
        {
            static AxisFactory CreateOwnedAxis(InputDevice parent, bool leftStick)
                => (bool x, bool positive)
                => new StickAxis(parent, leftStick, x, positive ? 1 : -1);

            internal Stick(InputDevice parent, bool leftStick)
                : base(CreateOwnedAxis(parent, leftStick))
            { }
        }

        private new class StickAxis(InputDevice parent, bool leftStick, bool x, int sign)
            : BoundedValueAxis(parent)
            , OpenTkAxisImplementation<GamePadState>
        {
            bool leftStick = leftStick;
            bool x = x;
            int sign = sign;

            public override string GetAxisString()
                => $"Controller Stick {(x ? "X" : "Y")} {(sign > 0 ? "positive" : "negative")}";

            void OpenTkAxisImplementation<GamePadState>.CreateEvents(GamePadState newState)
            {
                Vector2 stick = leftStick ? newState.ThumbSticks.Left : newState.ThumbSticks.Right;
                float paralell = x ? stick.X : stick.Y;
                float effectiveValue = paralell * sign;

                SetValue<StickAxis>(effectiveValue > 0 ? (effectiveValue < 1 ? effectiveValue : 1) : 0);
            }
        }
    }
}

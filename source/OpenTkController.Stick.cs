using OpenTK.Windowing.GraphicsLibraryFramework;

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
            , OpenTkAxisImplementation<GamepadState>
        {
            bool leftStick = leftStick;
            bool x = x;
            int sign = sign;

            public override string GetAxisString()
                => $"Controller Stick {(x ? "X" : "Y")} {(sign > 0 ? "positive" : "negative")}";

            unsafe void OpenTkAxisImplementation<GamepadState>.CreateEvents(GamepadState newState)
            {
                float effectiveValue = (x
                    ? (leftStick ? newState.Axes[0] : newState.Axes[2])
                    : (leftStick ? newState.Axes[1] : newState.Axes[3])
                    ) * sign;

                SetValue<StickAxis>(effectiveValue > 0 ? (effectiveValue < 1 ? effectiveValue : 1) : 0);
            }
        }
    }
}

using OpenTK.Input;

namespace ChaosFramework.Input.OpenTk
{
    using Axis;
    partial class OpenTkController
    {
        private class DPad
            : AxisArea
        {
            static AxisFactory CreateOwnedAxis(InputDevice parent)
                => (bool x, bool positive)
                => new DPadAxis(parent, x, positive ? 1 : -1);

            internal DPad(InputDevice parent)
                : base(CreateOwnedAxis(parent))
            { }
        }

        private class DPadAxis(InputDevice parent, bool x, int sign)
            : BoundedValueAxis(parent)
            , OpenTkAxisImplementation<GamePadState>
        {
            readonly bool x = x;
            readonly int sign = sign;

            public override string GetAxisString()
                => $"Controller D-Pad {(x ? "X" : "Y")} {(sign > 0 ? "positive" : "negative")}";

            void OpenTkAxisImplementation<GamePadState>.CreateEvents(GamePadState newState)
            {
                const float SQRT_2_HALF = 0.707106781f; // sqrt(2) / 2

                int vx = (newState.DPad.IsLeft ? -1 : 0) + (newState.DPad.IsRight ? 1 : 0);
                int vy = (newState.DPad.IsDown ? -1 : 0) + (newState.DPad.IsUp ? 1 : 0);
                int paralell = x ? vx : vy;
                bool anyOrthogonal = (x ? vy : vx) != 0;

                float effectiveValue = paralell * sign * (anyOrthogonal ? SQRT_2_HALF : 1);

                SetValue<DPadAxis>(effectiveValue > 0 ? effectiveValue : 0);
            }
        }
    }
}

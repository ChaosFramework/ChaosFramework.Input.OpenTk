using OpenTK.Input;

namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkMouse
    {
        public new class Position(InputDevice parent, Direction direction)
            : Mouse.Position(parent, direction)
            , OpenTkAxisImplementation<MouseState>
        {
            long exactNext, exactCurrent;
            int oldPos;

            public long exactValue => exactCurrent;
            public override float value => exactCurrent;

            protected override void AdvanceFrame()
            {
                exactCurrent = exactNext;
                base.AdvanceFrame();
            }

            void OpenTkAxisImplementation<MouseState>.CreateEvents(MouseState state)
            {
                int newPos = direction == Direction.X ? state.X : state.Y;
                int delta = newPos - oldPos;
                oldPos = newPos;
                SetValue<Position>(exactNext += delta);
            }
        }
    }
}

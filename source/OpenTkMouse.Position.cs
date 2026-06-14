using OpenTK.Mathematics;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkMouse
    {
        public new class Position(InputDevice parent, Direction direction)
            : Mouse.Position(parent, direction)
            , OpenTkAxisImplementation<Vector2>
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

            void OpenTkAxisImplementation<Vector2>.CreateEvents(Vector2 state)
            {
                int newPos = (int)(direction == Direction.X ? state.X : state.Y);
                int delta = newPos - oldPos;
                oldPos = newPos;
                SetValue<Position>(exactNext += delta);
            }
        }
    }
}

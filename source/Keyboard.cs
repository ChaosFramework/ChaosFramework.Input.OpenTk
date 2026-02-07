using ChaosFramework.Input.InputEvents;
using OpenTK.Input;

namespace ChaosFramework.Input.OpenTk
{
    public class Keyboard
        : Input.Keyboard
    {
        public class AnyKey(Keyboard keyboard)
            : InputAxis(keyboard)
        {
            public override string GetAxisString() => "AnyKey";

            protected override void Update(object data)
            { }

            internal void UpdateState()
            {
                bool a = keyboard.currentState.IsKeyDown(OpenTK.Input.Key.A);
                if (a && a != keyboard.oldState.IsKeyDown(OpenTK.Input.Key.A))
                {
                    AddEvent(new InputPushEvent<AnyKey>(this, 0, 1));
                }
            }
        }

        readonly AnyKey anyKey;
        KeyboardState oldState, currentState;

        public Keyboard(InputContext parent)
            : base(parent)
        {
            anyKey = new AnyKey(this);
            AddAxis(0, anyKey);
        }

        internal void UpdateState(KeyboardState newState)
        {
            oldState = currentState;
            currentState = newState;
            anyKey.UpdateState();
        }
    }
}

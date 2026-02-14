using System.Collections.Generic;
using ChaosFramework.Input.InputEvents;

namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkKeyboard
    {
        public partial class OpenTkKey(OpenTkKeyboard keyboard, HidUsage key)
            : Key(keyboard, key)
        {
            readonly OpenTK.Input.Key mappedKey = hid2Tk.GetValueOrDefault(key);

            public override string GetAxisString()
                => $"Keyboard Key {key}";

            protected override void Update(object data)
            { }

            internal void UpdateState()
            {
                bool down = keyboard.currentState.IsKeyDown(mappedKey);
                if (down != keyboard.oldState.IsKeyDown(mappedKey))
                    AddEvent(down
                        ? new InputPushEvent<OpenTkKey>(this, new InputChange(0, 1))
                        : new InputReleaseEvent<OpenTkKey>(this, new InputChange(1, 0))
                        );
            }
        }
    }
}

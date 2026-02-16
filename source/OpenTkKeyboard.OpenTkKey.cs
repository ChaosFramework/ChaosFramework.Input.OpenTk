using System.Collections.Generic;
using ChaosFramework.Input.InputEvents;
using OpenTK.Input;

namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkKeyboard
    {
        public partial class OpenTkKey(OpenTkKeyboard keyboard, HidUsage key)
            : Key(keyboard, key)
        {
            readonly OpenTK.Input.Key mappedKey = hid2Tk.GetValueOrDefault(key);

            bool previous, next;

            public override string GetAxisString()
                => $"Keyboard Key {key}";

            protected override void Update(object data)
                => value = next ? 1 : 0;

            internal void ProcessEvent(KeyboardState newState)
            {
                previous = next;
                next = newState.IsKeyDown(mappedKey);
                if (next != previous)
                {
                    InputChange change = new(previous ? 1 : 0, next ? 1 : 0);
                    AddEvent(next
                        ? new InputPushEvent<OpenTkKey>(this, change)
                        : new InputReleaseEvent<OpenTkKey>(this, change)
                        );
                    AddEvent(new InputChangeEvent<OpenTkKey>(this, change));
                }
            }
        }
    }
}

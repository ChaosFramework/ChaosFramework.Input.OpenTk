using OpenTK.Input;
using TkKey = OpenTK.Input.Key;

namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkKeyboard
    {
        public new partial class Key
            : Keyboard.Key
            , OpenTkAxisImplementation<KeyboardState>
        {
            public readonly TkKey tkKey;

            public Key(OpenTkKeyboard keyboard, HidUsage key)
                : base(keyboard, key)
            {
                if (!hid2Tk.TryGetValue(key, out tkKey))
                    tkKey = TkKey.Unknown;
            }

            public override string GetAxisString()
                => $"Keyboard Key {hidKey}";

            void OpenTkAxisImplementation<KeyboardState>.CreateEvents(KeyboardState newState)
                => SetDown<Key>(newState.IsKeyDown(tkKey));
        }
    }
}

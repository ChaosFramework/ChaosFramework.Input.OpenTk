using TkKey = OpenTK.Windowing.GraphicsLibraryFramework.Keys;

namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkKeyboard
    {
        public new partial class Key
            : Keyboard.Key
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

            internal void SetDown(bool value)
                => SetDown<Key>(value);
        }
    }
}

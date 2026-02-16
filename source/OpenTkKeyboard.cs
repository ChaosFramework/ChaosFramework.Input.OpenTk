using OpenTK.Input;

namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkKeyboard
        : Keyboard
    {
        public OpenTkKeyboard(InputContext parent)
            : base(parent)
        { }

        protected override Key GenerateKey(HidUsage hidUsage)
            => new OpenTkKey(this, hidUsage);

        internal void ProcessEvents(KeyboardState newState)
        {
            foreach (OpenTkKey key in this)
                key.ProcessEvent(newState);
        }
    }
}

using OpenTK.Input;

namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkKeyboard
        : Keyboard
    {
        KeyboardState oldState, currentState;

        public OpenTkKeyboard(InputContext parent)
            : base(parent)
        { }

        protected override Key GenerateKey(HidUsage hidUsage)
            => new OpenTkKey(this, hidUsage);

        internal void UpdateState(KeyboardState newState)
        {
            oldState = currentState;
            currentState = newState;
            foreach (OpenTkKey key in this)
                key.UpdateState();
        }
    }
}

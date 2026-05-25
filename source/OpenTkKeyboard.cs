using OpenTK.Input;

namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkKeyboard
        : Keyboard
        , StateTracker<KeyboardState>
    {
        internal sealed class Implementation(OpenTkKeyboard parent, int index)
            : OpenTkDeviceImplementation<OpenTkKeyboard, KeyboardState>(parent, index)
            ;

        readonly TrackedState<KeyboardState> state = new();
        TrackedState<KeyboardState> StateTracker<KeyboardState>.state => state;

        KeyboardState StateTracker<KeyboardState>.GetImmediate(int index)
            => OpenTK.Input.Keyboard.GetState(index);

        public OpenTkKeyboard(InputContext parent)
            : base(parent)
        { }

        public override void AdvanceFrame()
        {
            base.AdvanceFrame();
            state.AdvanceFrame();
        }

        public override bool IsConnected()
            => state.consistent.IsConnected;

        protected override Keyboard.Key GenerateKey(HidUsage hidUsage)
            => new Key(this, hidUsage);
    }
}

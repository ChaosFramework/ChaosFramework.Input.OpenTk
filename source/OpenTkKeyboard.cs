using OpenTK.Input;

namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkKeyboard
        : Keyboard
        , StateTrackerOwner<KeyboardState>
    {
        internal sealed class Implementation(OpenTkKeyboard parent, int index)
            : OpenTkDeviceImplementation<OpenTkKeyboard, KeyboardState>(parent, index)
            ;

        StateTracker<KeyboardState> stateTracker = new StateTracker<KeyboardState>();
        StateTracker<KeyboardState> StateTrackerOwner<KeyboardState>.stateTracker => stateTracker;
        KeyboardState StateTrackerOwner<KeyboardState>.GetImmediate(int index)
            => OpenTK.Input.Keyboard.GetState(index);

        public OpenTkKeyboard(InputContext parent)
            : base(parent)
        { }

        public override void AdvanceFrame()
        {
            base.AdvanceFrame();
            stateTracker.AdvanceFrame();
        }

        public override bool IsConnected()
            => stateTracker.consistent.IsConnected;

        protected override Keyboard.Key GenerateKey(HidUsage hidUsage)
            => new Key(this, hidUsage);
    }
}

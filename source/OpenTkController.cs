using System;
using System.Collections.Generic;
using ChaosUtil.Reflection;
using OpenTK.Input;

namespace ChaosFramework.Input.OpenTk
{
    partial class OpenTkController
        : ChaosFramework.Input.Controller
        , StateTrackerOwner<GamePadState>
    {
        internal class Implementation(OpenTkController parent, int index)
            : OpenTkDeviceImplementation<OpenTkController, GamePadState>(parent, index)
            ;

        static ButtonState MapButtonState(GamePadState tkState, Buttons hidUsage)
        {
            switch (hidUsage)
            {
                case Buttons.A: return tkState.Buttons.A;
                case Buttons.B: return tkState.Buttons.B;
                case Buttons.X: return tkState.Buttons.X;
                case Buttons.Y: return tkState.Buttons.Y;
                case Buttons.LB: return tkState.Buttons.LeftShoulder;
                case Buttons.RB: return tkState.Buttons.RightShoulder;
                case Buttons.LS: return tkState.Buttons.LeftStick;
                case Buttons.RS: return tkState.Buttons.RightStick;
                case Buttons.Start: return tkState.Buttons.Start;
                case Buttons.Back: return tkState.Buttons.Back;
                case Buttons.Home: return tkState.Buttons.BigButton;
                default: return ButtonState.Released;
            }
        }

        readonly Dictionary<Buttons, Button> buttons = [];
        readonly DPad dPad;
        readonly Stick leftStick, rightStick;
        readonly Trigger leftTrigger, rightTrigger;

        readonly StateTracker<GamePadState> stateTracker = new();
        StateTracker<GamePadState> StateTrackerOwner<GamePadState>.stateTracker => stateTracker;

        GamePadState StateTrackerOwner<GamePadState>.GetImmediate(int index)
            => GamePad.GetState(index);

        public OpenTkController(InputContext context)
            : base(context)
        {
            foreach (Buttons btn in Enum<Buttons>.GetValues())
                buttons[btn] = new Button(this, btn);

            dPad = new DPad(this);
            leftStick = new Stick(this, true);
            rightStick = new Stick(this, false);
            leftTrigger = new Trigger(this, true);
            rightTrigger = new Trigger(this, false);
        }

        public override IEnumerator<InputAxis> GetEnumerator()
        {
            foreach (Button button in buttons.Values)
                yield return button;

            foreach (DPadAxis axis in dPad.EnumerateAxes())
                yield return axis;

            foreach (StickAxis axis in leftStick.EnumerateAxes())
                yield return axis;
            foreach (StickAxis axis in rightStick.EnumerateAxes())
                yield return axis;

            yield return leftTrigger;
            yield return rightTrigger;
        }

        Button MakeOrRetrieveButton(ushort hidUsage)
            => buttons.TryGetValue((Buttons)hidUsage, out Button known)
                ? known
                : new Button(this, (Buttons)hidUsage);

        protected override InputAxis GetByUsageInternal(HidPage hidPage, ushort hidUsage, int subIndex)
            => hidPage switch
            {
                HidPage.Button => (InputAxis)MakeOrRetrieveButton(hidUsage),
                _ => throw new ArgumentException("unknown usage")
            };

        public override void AdvanceFrame()
        {
            base.AdvanceFrame();
            stateTracker.AdvanceFrame();
        }

        public override sealed bool IsConnected()
            => stateTracker.consistent.IsConnected;
    }
}

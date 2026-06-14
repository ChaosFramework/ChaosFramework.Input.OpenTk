using System;
using System.Collections.Generic;
using ChaosUtil.Reflection;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace ChaosFramework.Input.OpenTk
{
    partial class OpenTkController
        : ChaosFramework.Input.Controller
        , StateTracker<GamepadState>
    {
        internal class Implementation(OpenTkController parent, int index)
            : OpenTkDeviceImplementation<OpenTkController, GamepadState>(parent, index)
            ;

        unsafe static InputAction MapButtonState(GamepadState tkState, Buttons hidUsage)
            => (InputAction)(hidUsage switch
            {
                < Buttons.A => 0,
                < Buttons.LS => tkState.Buttons[(int)hidUsage - 1],
                Buttons.Home => tkState.Buttons[8],
                Buttons.LS => tkState.Buttons[9],
                Buttons.RS => tkState.Buttons[10],
                _ => 0
            });

        readonly Dictionary<Buttons, Button> buttons = [];
        readonly DPad dPad;
        readonly Stick leftStick, rightStick;
        readonly Trigger leftTrigger, rightTrigger;

        readonly TrackedState<GamepadState> state = new();
        TrackedState<GamepadState> StateTracker<GamepadState>.state => state;

        GamepadState StateTracker<GamepadState>.GetImmediate(int index)
            => GLFW.GetGamepadState(index, out GamepadState result) ? result : default;

        public OpenTkController(DeviceHost deviceHost)
            : base(deviceHost.context)
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
            state.AdvanceFrame();
        }

        public override sealed bool IsConnected()
            => true; // TODO
    }
}

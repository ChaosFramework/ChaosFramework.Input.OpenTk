using System.Collections;
using System.Collections.Generic;

namespace ChaosFramework.Input.OpenTk
{
    public class DeviceHost(InputContext parent)
        : InputDeviceHost
    {
        readonly OpenTkKeyboard keyboard = new(parent);

        void InputDeviceHost.RefreshDeviceList() { }

        void InputDeviceHost.Update()
            => keyboard.ProcessEvents(OpenTK.Input.Keyboard.GetState());

        IEnumerator<InputDevice> IEnumerable<InputDevice>.GetEnumerator()
            => GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        public IEnumerator<InputDevice> GetEnumerator()
        {
            yield return keyboard;
        }
    }
}

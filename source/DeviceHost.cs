using ChaosFramework.Collections;
using ChaosFramework.Collections.Immutable;
using Activator = System.Activator;
using SysCol = System.Collections.Generic;
using Type = System.Type;

namespace ChaosFramework.Input.OpenTk
{
    public class DeviceHost(InputContext context)
        : InputDeviceHost
    {
        private readonly record struct DeviceTypes(Type implementation, Type exposedDevice);

        static DeviceTypes FindExposedForimplementation(Type implementation) => new(implementation, implementation.BaseType.GetGenericArguments()[0]);

        // TODO: see if assemblymanager can or should be able to produce these internal types
        static readonly ImmutableArray<DeviceTypes> ImplementationTypes = new[]
        {
            FindExposedForimplementation(typeof(OpenTkMouse.Implementation)),
            FindExposedForimplementation(typeof(OpenTkKeyboard.Implementation)),
            FindExposedForimplementation(typeof(OpenTkController.Implementation)),
        };

        readonly InputContext context = context;

        readonly LinkedList<OpenTkDeviceImplementation> implementations = [];

        void InputDeviceHost.Update()
        {
            foreach (OpenTkDeviceImplementation impl in implementations)
                impl.InputThreadUpdate();
        }

        SysCol.IEnumerable<InputDevice> InputDeviceHost.RefreshDeviceList()
        {
            // TODO: try and find a way to not duplicate or skip devices that have been disconnecterered and/or reconnected
            SysCol.Dictionary<Type, SysCol.HashSet<int>> ints = [];
            foreach (OpenTkDeviceImplementation impl in implementations)
                if (impl.parentInternal.IsConnected())
                {
                    ints.GetOrCreateValue(impl.GetType()).Add(impl.index);
                    yield return impl.parentInternal;
                }
                else
                    implementations.Remove(impl);

            foreach (DeviceTypes types in ImplementationTypes)
                for (int i = 0; i < 1000; ++i)
                {
                    if (ints.TryGetValue(types.implementation, out SysCol.HashSet<int> set) && set.Contains(i))
                        continue;

                    InputDevice exposedDevice = (InputDevice)Activator.CreateInstance(types.exposedDevice, context);
                    OpenTkDeviceImplementation d = (OpenTkDeviceImplementation)Activator.CreateInstance(types.implementation, exposedDevice, i);
                    if (d.parentInternal.IsConnected())
                    {
                        implementations.Add(d);
                        yield return d.parentInternal;
                    }
                }
        }
    }
}

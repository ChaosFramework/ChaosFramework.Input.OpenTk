using System.Linq;
using ChaosFramework.Collections;
using ChaosFramework.Collections.Immutable;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;
using Activator = System.Activator;
using SysCol = System.Collections.Generic;
using Type = System.Type;

namespace ChaosFramework.Input.OpenTk
{
    public class DeviceHost
        : InputDeviceHost
    {
        private readonly record struct DeviceTypes(Type implementation, Type exposedDevice);

        static DeviceTypes FindExposedForimplementation(Type implementation) => new(implementation, implementation.BaseType.GetGenericArguments()[0]);

        public readonly InputContext context;
        internal readonly NativeWindow window;

        readonly OpenTkKeyboard keyboard;
        readonly OpenTkMouse.Implementation mouse;
        readonly LinkedList<OpenTkController.Implementation> controllers = [];

        readonly GLFWCallbacks.MouseButtonCallback mouseCallback;
        readonly GLFWCallbacks.KeyCallback keyCallback;

        public DeviceHost(InputContext context, NativeWindow window)
        {
            this.window = window ?? new NativeWindow(new NativeWindowSettings {
                Size = new OpenTK.Mathematics.Vector2i(1,1),
                Title = "HiddenInput",
                StartVisible = false,      // don't show
                WindowBorder = OpenTK.Windowing.Common.WindowBorder.Hidden
            });

            this.context = context;
            keyboard = new OpenTkKeyboard(this);
            mouse = new OpenTkMouse.Implementation(new OpenTkMouse(this), 0);
        }

        void InputDeviceHost.Update()
        {
            mouse.InputThreadUpdate();

            foreach (OpenTkDeviceImplementation impl in controllers)
                impl.InputThreadUpdate();
        }

        SysCol.IEnumerable<InputDevice> InputDeviceHost.RefreshDeviceList()
        {
            yield return keyboard;
            yield return mouse.parentInternal;

            // TODO: try and find a way to not duplicate or skip devices that have been disconnecterered and/or reconnected
            SysCol.HashSet<int> ints = [];
            foreach (OpenTkController.Implementation impl in controllers)
                if (impl.parentInternal.IsConnected())
                {
                    ints.Add(impl.index);
                    yield return impl.parentInternal;
                }
                else
                    controllers.Remove(impl);

            for (int i = 0; i < 16; ++i) // Invalid joystick ID 16 (this is thrown from OpenTKs default GLFW error handler, if you find this exception inconvenient set your own error callback using GLFWProvider.SetErrorCallback)
            {
                if (ints.Contains(i))
                    continue;

                OpenTkController exposedDevice = new OpenTkController(this);
                OpenTkController.Implementation d = new OpenTkController.Implementation(exposedDevice, i);
                if (d.parentInternal.IsConnected())
                {
                    controllers.Add(d);
                    yield return d.parentInternal;
                }
            }
        }
    }
}

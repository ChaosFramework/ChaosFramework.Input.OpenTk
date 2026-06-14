using System.Linq;
using ChaosAnalyzers.ClassIntegrity;

namespace ChaosFramework.Input.OpenTk
{
    internal interface StateTracker<State>
    {
        TrackedState<State> state { get; }
        State GetImmediate(int index);
    }

    internal class TrackedState<State>
    {
        public State intermediate, consistent;
        public void AdvanceFrame()
            => consistent = intermediate;
    }

    internal interface OpenTkAxisImplementation<State>
    {
        void CreateEvents(State newState);
    }

    internal abstract class OpenTkDeviceImplementation
    {
        protected internal abstract InputDevice parentInternal { get; }
        internal readonly int index;

        protected internal abstract void InputThreadUpdate();

        protected OpenTkDeviceImplementation(int index)
        {
            this.index = index;
        }
    }

    internal abstract class OpenTkDeviceImplementation<Parent, State>
        : OpenTkDeviceImplementation
        where Parent : InputDevice, StateTracker<State>
    {
        protected readonly Parent parent;

        protected internal sealed override InputDevice parentInternal => parent;

        protected internal sealed override void InputThreadUpdate()
        {
            parent.state.intermediate = parent.GetImmediate(index);
            foreach (OpenTkAxisImplementation<State> axis in parent.OfType<OpenTkAxisImplementation<State>>())
                axis.CreateEvents(parent.state.intermediate);
        }

        [ExplicitConstructor]
        public OpenTkDeviceImplementation(Parent parent, int index)
            : base(index)
        {
            this.parent = parent;
            parent.state.intermediate = parent.state.consistent = parent.GetImmediate(index);
        }
    }
}

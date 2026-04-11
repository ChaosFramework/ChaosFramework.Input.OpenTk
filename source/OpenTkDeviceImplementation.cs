using ChaosAnalyzers.ClassIntegrity;

namespace ChaosFramework.Input.OpenTk
{

    internal interface StateTrackerOwner<State>
    {
        StateTracker<State> stateTracker { get; }
        State GetImmediate(int index);
    }

    internal class StateTracker<State>
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
        where Parent : InputDevice, StateTrackerOwner<State>
    {
        protected readonly Parent parent;

        protected internal sealed override InputDevice parentInternal => parent;

        protected internal sealed override void InputThreadUpdate()
        {
            parent.stateTracker.intermediate = parent.GetImmediate(index);
            foreach (OpenTkAxisImplementation<State> axis in parent)
                axis.CreateEvents(parent.stateTracker.intermediate);
        }

        [ExplicitConstructor]
        public OpenTkDeviceImplementation(Parent parent, int index)
            : base(index)
        {
            this.parent = parent;
            parent.stateTracker.intermediate = parent.stateTracker.consistent = parent.GetImmediate(index);
        }
    }
}

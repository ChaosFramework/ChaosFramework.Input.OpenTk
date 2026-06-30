namespace ChaosFramework.Input.OpenTk
{
    public partial class OpenTkMouse
    {
        public new class Wheel(Mouse parent, WheelDirection dir)
            : Mouse.Wheel(parent, dir)
        {
            float abs;

            internal void SetValue(float delta)
                => SetValue<Wheel>(abs += delta);
        }
    }
}

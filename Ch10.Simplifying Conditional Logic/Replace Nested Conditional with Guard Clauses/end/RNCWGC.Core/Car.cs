namespace RNCWGC.Core
{
    public class Car
    {
        public Car(bool hasBrokenWindows, bool isEngineOld)
        {
            HasBrokenWindows = hasBrokenWindows;
            IsEngineOld = isEngineOld;
        }

        public bool HasBrokenWindows { get; }
        public bool IsEngineOld { get; }
    }
}
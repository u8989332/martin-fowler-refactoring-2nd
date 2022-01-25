namespace IPO.Core
{
    // [mf-range] pattern
    public class WeightRange
    {
        public WeightRange(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public int Min { get; }
        public int Max { get; }

        public bool Contains(int arg)
        {
            return arg >= Min && arg <= Max;
        }
    }
}
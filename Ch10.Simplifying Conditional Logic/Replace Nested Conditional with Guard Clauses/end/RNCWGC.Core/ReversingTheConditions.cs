namespace RNCWGC.Core
{
    public class ReversingTheConditions
    {
        public static double GetStoneValue(Stone stone)
        {
            if (stone.Hardness <= 3 || stone.Fluorescence <= 2 || stone.Clarity <= 4)
            {
                return 0;
            }

            return 215.94 * stone.Hardness * stone.Fluorescence * stone.Clarity;
        }
    }
}

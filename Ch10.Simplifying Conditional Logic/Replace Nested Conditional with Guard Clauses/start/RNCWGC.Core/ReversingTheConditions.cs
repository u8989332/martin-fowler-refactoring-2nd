namespace RNCWGC.Core
{
    public class ReversingTheConditions
    {
        public static double GetStoneValue(Stone stone)
        {
            double result = 0;
            if (stone.Hardness > 3)
            {
                if (stone.Fluorescence > 2 && stone.Clarity > 4)
                {
                    result = 215.94 * stone.Hardness * stone.Fluorescence * stone.Clarity;
                }
            }

            return result;
        }
    }
}

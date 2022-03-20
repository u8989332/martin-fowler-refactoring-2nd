namespace SplitVariable.Core
{
    public class AssigningToAnInputParameter
    {
        public static int KPI(int goodPerformance, int badPerformance)
        {
            int result = goodPerformance;
            if (result > 5)
            {
                result = result + 2;
            }

            if (badPerformance > 2)
            {
                result = result - 1;
            }

            return result;
        }
    }
}

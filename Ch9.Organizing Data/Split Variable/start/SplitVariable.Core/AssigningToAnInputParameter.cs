namespace SplitVariable.Core
{
    public class AssigningToAnInputParameter
    {
        public static int KPI(int goodPerformance, int badPerformance)
        {
            if (goodPerformance > 5)
            {
                goodPerformance = goodPerformance + 2;
            }

            if (badPerformance > 2)
            {
                goodPerformance = goodPerformance - 1;
            }

            return goodPerformance;
        }
    }
}

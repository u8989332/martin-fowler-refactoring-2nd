namespace CFIC.Core
{
    public class BonusCoreModule
    {
        public static double TaxThreshold(double annualSalary)
        {
            return annualSalary * 0.3;
        }

        public static double BaseBonus(double annualSalary, int poorPerformanceCount)
        {
            if (poorPerformanceCount >= 2)
            {
                return annualSalary * 0.05;
            }

            return 0.1 * annualSalary;
        }
    }
}
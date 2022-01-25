using System;

namespace CFIC.Core
{
    public class SalaryBonusExample
    {
        public static double GetSalaryBonusTax()
        {
            var user = GetEmployee();
            var baseBonus = BonusCoreModule.BaseBonus(user.AnnualSalary, user.PoorPerformanceCount) * (user.Seniority * 1.2);
            var taxableCharge = Math.Max(0, baseBonus - BonusCoreModule.TaxThreshold(user.AnnualSalary));

            return taxableCharge;
        }

        private static Employee GetEmployee()
        {
            return new Employee("John", 6, 65000.54d, 3);
        }
    }
}

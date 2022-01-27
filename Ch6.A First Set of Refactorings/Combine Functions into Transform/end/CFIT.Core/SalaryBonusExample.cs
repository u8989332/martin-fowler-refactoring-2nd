using System;

namespace CFIT.Core
{
    public class SalaryBonusExample
    {
        public static double GetSalaryBonusTax()
        {
            var rawUser = GetEmployee();
            var user = EnrichEmployee(rawUser);

            return user.TaxableCharge;
        }

        private static Employee EnrichEmployee(Employee original)
        {
            var result = original.DeepCopy();
            result.BaseBonus = CalculateBaseBonus(result);
            result.TaxableCharge = Math.Max(0, result.BaseBonus - BonusCoreModule.TaxThreshold(result.AnnualSalary));
            return result;
        }

        private static double CalculateBaseBonus(Employee user)
        {
            return BonusCoreModule.BaseBonus(user.AnnualSalary, user.PoorPerformanceCount) * (user.Seniority * 1.2);
        }

        private static Employee GetEmployee()
        {
            return new Employee("John", 6, 65000.54d, 3);
        }
    }
}

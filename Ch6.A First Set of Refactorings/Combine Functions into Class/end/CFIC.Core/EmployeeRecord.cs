using System;

namespace CFIC.Core
{
    public class EmployeeRecord
    {
        public EmployeeRecord(Employee employee)
        {
            Name = employee.Name;
            Seniority = employee.Seniority;
            AnnualSalary = employee.AnnualSalary;
            PoorPerformanceCount = employee.PoorPerformanceCount;

        }

        public string Name { get; }
        public int Seniority { get; }
        public double AnnualSalary { get; set; }
        public int PoorPerformanceCount { get; set; }

        public double BaseBonus()
        {
            return BonusCoreModule.BaseBonus(AnnualSalary, PoorPerformanceCount) * (Seniority * 1.2);
        }

        public double TaxableCharge()
        {
            return Math.Max(0, BaseBonus() - BonusCoreModule.TaxThreshold(this.AnnualSalary));
        }
    }
}
using System;

namespace ExtractVariable.Core
{
    public class InAClassEmployeeExample
    {
        private readonly EmployeeRecord _record;

        public InAClassEmployeeExample(EmployeeRecord record)
        {
            _record = record;
        }

        public int Seniority => _record.Seniority;
        public double AnnualSalary => _record.AnnualSalary;
        public int PoorPerformanceCount => _record.PoorPerformanceCount;

        public double Bonus =>
            SeniorityAnnualSalary
            - PoorPerformance
            + HighSeniority;

        public double SeniorityAnnualSalary => AnnualSalary * Seniority * 0.05;
        public double PoorPerformance => Math.Max(0, PoorPerformanceCount - 2) * AnnualSalary * 0.01;
        public double HighSeniority => Math.Max(Seniority - 5, 0) * AnnualSalary * 0.02;
    }
}
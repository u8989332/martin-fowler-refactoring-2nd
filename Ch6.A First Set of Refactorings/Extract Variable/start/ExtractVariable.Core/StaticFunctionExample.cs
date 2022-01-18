using System;

namespace ExtractVariable.Core
{
    public class StaticFunctionExample
    {
        public static double Bonus(EmployeeForStaticFunction emp)
        {
            // bonus is based on seniority annualSalary - poor performance + high seniority 
            return emp.AnnualSalary * emp.Seniority * 0.05
                - Math.Max(0, emp.PoorPerformanceCount - 2) * emp.AnnualSalary * 0.01
                + Math.Max(emp.Seniority - 5, 0) * emp.AnnualSalary * 0.02;
        }
    }
}

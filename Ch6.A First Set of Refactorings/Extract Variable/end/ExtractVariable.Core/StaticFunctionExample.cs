using System;

namespace ExtractVariable.Core
{
    public class StaticFunctionExample
    {
        public static double Bonus(EmployeeForStaticFunction emp)
        {
            double seniorityAnnualSalary = emp.AnnualSalary * emp.Seniority * 0.05;
            double poorPerformance = Math.Max(0, emp.PoorPerformanceCount - 2) * emp.AnnualSalary * 0.01;
            double highSeniority = Math.Max(emp.Seniority - 5, 0) * emp.AnnualSalary * 0.02;
            return seniorityAnnualSalary - poorPerformance + highSeniority;
        }
    }
}

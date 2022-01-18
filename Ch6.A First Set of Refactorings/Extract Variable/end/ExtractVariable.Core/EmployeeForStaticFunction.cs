namespace ExtractVariable.Core
{
    public class EmployeeForStaticFunction
    {
        public EmployeeForStaticFunction(int seniority, double annualSalary, int poorPerformanceCount)
        {
            Seniority = seniority;
            AnnualSalary = annualSalary;
            PoorPerformanceCount = poorPerformanceCount;
        }

        public int Seniority { get; }
        public double AnnualSalary { get; }
        public int PoorPerformanceCount { get; }

    }
}
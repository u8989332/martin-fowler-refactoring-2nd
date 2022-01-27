namespace CFIT.Core
{
    public class Employee
    {
        public string Name;
        public int Seniority;
        public double AnnualSalary;
        public int PoorPerformanceCount;

        public Employee(
            string name,
            int seniority,
            double annualSalary,
            int poorPerformanceCount)
        {
            Name = name;
            Seniority = seniority;
            AnnualSalary = annualSalary;
            PoorPerformanceCount = poorPerformanceCount;
        }

        public double BaseBonus;
        public double TaxableCharge;

        public Employee DeepCopy()
        {
            return new Employee(Name, Seniority, AnnualSalary, PoorPerformanceCount);
        }
    }
}
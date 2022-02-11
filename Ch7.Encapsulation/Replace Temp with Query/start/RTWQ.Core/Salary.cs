namespace RTWQ.Core
{
    public class Salary
    {
        private readonly double _companyPerformance;
        private readonly Employee _employee;

        public Salary(double companyPerformance, Employee employee)
        {
            _companyPerformance = companyPerformance;
            _employee = employee;
        }

        public double Bonus
        {
            get
            {
                var baseBonus = _companyPerformance * _employee.AnnualSalary;
                var raiseFactor = 1.02;
                if (baseBonus < 10000)
                {
                    raiseFactor += 0.03;
                }

                return baseBonus * raiseFactor;
            }
        }
    }
}
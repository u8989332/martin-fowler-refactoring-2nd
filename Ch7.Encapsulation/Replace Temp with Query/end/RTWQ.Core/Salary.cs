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

        public double Bonus => BaseBonus * RaiseFactor;

        private double RaiseFactor
        {
            get
            {
                var raiseFactor = 1.02;
                if (BaseBonus < 10000)
                {
                    raiseFactor += 0.03;
                }

                return raiseFactor;
            }
        }

        private double BaseBonus => _companyPerformance * _employee.AnnualSalary;
    }
}
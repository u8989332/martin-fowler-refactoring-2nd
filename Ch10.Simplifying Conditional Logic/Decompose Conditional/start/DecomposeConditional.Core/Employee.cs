using System;

namespace DecomposeConditional.Core
{
    public class Employee
    {
        private readonly AnnualBonusPlan _annualBonusPlan;

        public Employee(DateTime joinDate, double salary, AnnualBonusPlan annualBonusPlan)
        {
            JoinDate = joinDate;
            Salary = salary;
            _annualBonusPlan = annualBonusPlan;
        }

        public DateTime JoinDate { get; }
        public double Salary { get; }

        public double Bonus()
        {
            double result = 0;
            if (JoinDate >= _annualBonusPlan.JuniorJoinDate)
            {
                result = Salary * _annualBonusPlan.JuniorRatio;
            }
            else
            {
                result = Salary * _annualBonusPlan.SeniorRatio;
            }

            return result;
        }
    }
}
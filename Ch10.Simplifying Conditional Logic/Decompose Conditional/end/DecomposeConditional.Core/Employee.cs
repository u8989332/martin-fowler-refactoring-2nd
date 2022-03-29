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
            return IsJunior() ? JuniorBonus() : SeniorBonus();
        }

        private double SeniorBonus()
        {
            return Salary * _annualBonusPlan.SeniorRatio;
        }

        private double JuniorBonus()
        {
            return Salary * _annualBonusPlan.JuniorRatio;
        }

        private bool IsJunior()
        {
            return JoinDate >= _annualBonusPlan.JuniorJoinDate;
        }
    }
}
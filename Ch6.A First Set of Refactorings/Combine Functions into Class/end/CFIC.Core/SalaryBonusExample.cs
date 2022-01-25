using System;

namespace CFIC.Core
{
    public class SalaryBonusExample
    {
        public static double GetSalaryBonusTax()
        {
            var rawUser = GetEmployee();
            var user = new EmployeeRecord(rawUser);
            var taxableCharge = user.TaxableCharge();

            return taxableCharge;
        }

        private static Employee GetEmployee()
        {
            return new Employee("John", 6, 65000.54d, 3);
        }
    }
}

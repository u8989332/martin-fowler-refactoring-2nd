namespace MoveFunction.Core
{
    public class EmployeeType
    {
        public EmployeeType(bool isManager)
        {
            IsManager = isManager;
        }

        public bool IsManager { get; }

        public int BonusAnnualLeave(Employee employee)
        {
            if (this.IsManager)
            {
                int baseAnnualLeave = 5;
                if (employee.PerformanceGoodCount <= 6)
                {
                    return baseAnnualLeave;
                }

                return baseAnnualLeave + (employee.PerformanceGoodCount - 6) * 2;
            }

            return (int)(employee.PerformanceGoodCount * 0.5);
        }
    }
}
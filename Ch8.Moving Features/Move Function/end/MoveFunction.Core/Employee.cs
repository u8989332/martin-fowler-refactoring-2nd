namespace MoveFunction.Core
{
    public class Employee
    {
        private readonly EmployeeType _type;

        public Employee(int performanceGoodCount, EmployeeType type)
        {
            PerformanceGoodCount = performanceGoodCount;
            _type = type;
        }

        public int AnnualLeave
        {
            get
            {
                int result = 5;
                if (this.PerformanceGoodCount > 0)
                {
                    result += this.BonusAnnualLeave;
                }

                return result;
            }
        }

        private int BonusAnnualLeave => this._type.BonusAnnualLeave(this);

        public int PerformanceGoodCount { get; }
    }
}
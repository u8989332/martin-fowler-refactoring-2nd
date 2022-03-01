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

        private int BonusAnnualLeave
        {
            get
            {
                if (this._type.IsManager)
                {
                    int baseAnnualLeave = 5;
                    if (this.PerformanceGoodCount <= 6)
                    {
                        return baseAnnualLeave;
                    }

                    return baseAnnualLeave + (this.PerformanceGoodCount - 6) * 2;
                }

                return (int) (this.PerformanceGoodCount * 0.5);
            }
        }

        public int PerformanceGoodCount { get; }
    }
}
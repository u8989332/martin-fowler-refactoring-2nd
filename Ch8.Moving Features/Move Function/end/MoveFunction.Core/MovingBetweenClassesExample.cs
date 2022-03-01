namespace MoveFunction.Core
{
    public class MovingBetweenClassesExample
    {
        public static MovingBetweenClassesExampleResult GetAnnualLeaves()
        {
            Employee emp1 = new Employee(7, new EmployeeType(true));
            Employee emp2 = new Employee(4, new EmployeeType(false));

            return new MovingBetweenClassesExampleResult(emp1.AnnualLeave, emp2.AnnualLeave);
        }
    }

    public class MovingBetweenClassesExampleResult
    {
        public MovingBetweenClassesExampleResult(int emp1, int emp2)
        {
            Emp1 = emp1;
            Emp2 = emp2;
        }

        public int Emp1 { get; }
        public int Emp2 { get; }
    }
}
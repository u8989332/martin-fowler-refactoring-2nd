namespace ISC.Core
{
    public class Employee
    {
        public Employee(Job job)
        {
            Job = job;
        }

        public Job Job { get; }
    }
}
namespace ISC.Core
{
    public class TransformJob
    {
        public string Name { get; }
        public TransformSalary Salary { get; }
        public string BonusPlan { get; set; }

        public TransformJob(string name) : this(name, new TransformSalary(0))
        {

        }

        public TransformJob(string name, TransformSalary salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
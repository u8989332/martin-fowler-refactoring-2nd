namespace ISC.Core
{
    public class TransformJob : ITransformJob
    {
        public bool IsUnassigned { get; set; }
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

        // deep copy
        public TransformJob(ITransformJob job)
        {
            Name = job.Name;
            BonusPlan = job.BonusPlan;
            Salary = new TransformSalary(job.Salary);
        }
    }
}
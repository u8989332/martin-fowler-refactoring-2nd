namespace ISC.Core
{
    public class Job
    {
        public virtual string Name { get; }
        public virtual Salary Salary { get; }
        public virtual string BonusPlan { get; set; }

        public Job(string name) : this(name, new Salary(0))
        {

        }

        public Job(string name, Salary salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual bool IsUnassigned => false;
    }
}
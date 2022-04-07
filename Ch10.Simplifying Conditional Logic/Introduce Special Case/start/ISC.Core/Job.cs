namespace ISC.Core
{
    public class Job
    {
        public string Name { get; }
        public Salary Salary { get; }
        public string BonusPlan { get; set; }

        public Job(string name) : this(name, new Salary(0))
        {

        }

        public Job(string name, Salary salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
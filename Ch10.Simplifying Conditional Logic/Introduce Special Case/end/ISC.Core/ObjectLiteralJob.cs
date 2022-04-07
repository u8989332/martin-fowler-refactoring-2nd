namespace ISC.Core
{
    public class ObjectLiteralJob : IObjectLiteralJob
    {
        public string Name { get; }
        public ObjectLiteralSalary Salary { get; }
        public string BonusPlan { get; set; }

        public ObjectLiteralJob(string name) : this(name, new ObjectLiteralSalary(0))
        {

        }

        public ObjectLiteralJob(string name, ObjectLiteralSalary salary)
        {
            Name = name;
            Salary = salary;
        }

        public bool IsUnassigned => false;
    }
}
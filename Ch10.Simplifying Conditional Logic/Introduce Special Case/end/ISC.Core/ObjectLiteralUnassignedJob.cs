namespace ISC.Core
{
    public class ObjectLiteralUnassignedJob : IObjectLiteralJob
    {
        public bool IsUnassigned => true;
        public string Name => "Intern";
        public string BonusPlan => "New Plan";
        public ObjectLiteralSalary Salary => new ObjectLiteralSalary(0);
    }
}
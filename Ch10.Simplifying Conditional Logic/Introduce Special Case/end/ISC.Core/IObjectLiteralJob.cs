namespace ISC.Core
{
    public interface IObjectLiteralJob
    {
        bool IsUnassigned { get; }
        string Name { get; }
        string BonusPlan { get; }
        ObjectLiteralSalary Salary { get; }
    }
}
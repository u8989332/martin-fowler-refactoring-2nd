namespace ISC.Core
{
    public interface ITransformJob
    {
        bool IsUnassigned { get; set; }
        string Name { get; }
        string BonusPlan { get; }
        TransformSalary Salary { get; }
    }
}
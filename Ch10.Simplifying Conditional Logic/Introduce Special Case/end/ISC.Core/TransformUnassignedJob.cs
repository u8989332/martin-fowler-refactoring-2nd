namespace ISC.Core
{
    public class TransformUnassignedJob : ITransformJob
    {
        public bool IsUnassigned { get; set; } = true;
        public string Name => "Intern";
        public string BonusPlan => "New Plan";
        public TransformSalary Salary => new TransformSalary(0);
    }
}
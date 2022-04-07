namespace ISC.Core
{
    public class UnassignedJob : Job
    {
        public override bool IsUnassigned => true;
        public override string Name => "Intern";
        public override Salary Salary => new NullSalary();

        public override string BonusPlan
        {
            get => "New Plan";
            set
            {
                /* ignore */
            }
        }

        public UnassignedJob() : base("Unassigned")
        {
        }
    }
}
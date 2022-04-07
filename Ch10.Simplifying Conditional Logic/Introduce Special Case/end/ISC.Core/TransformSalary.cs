namespace ISC.Core
{
    public class TransformSalary
    {
        public TransformSalary(int baseAmount)
        {
            BaseAmount = baseAmount;
        }

        // deep copy
        public TransformSalary(TransformSalary salary)
        {
            BaseAmount = salary.BaseAmount;
        }

        public int BaseAmount { get; }
    }
}
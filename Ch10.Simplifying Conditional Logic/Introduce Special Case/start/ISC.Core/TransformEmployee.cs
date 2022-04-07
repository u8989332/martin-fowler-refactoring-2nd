namespace ISC.Core
{
    public class TransformEmployee
    {
        public TransformEmployee(TransformJob job)
        {
            Job = job;
        }

        public TransformJob Job { get; }
    }
}
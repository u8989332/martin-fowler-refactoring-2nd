namespace ISC.Core
{
    public class TransformEmployee
    {
        public TransformEmployee(TransformJob job)
        {
            Job = job;
        }

        // depp copy
        public TransformEmployee(TransformEmployee emp)
        {
            Job = new TransformJob(emp.Job);
        }

        public ITransformJob Job { get; set; }
    }
}
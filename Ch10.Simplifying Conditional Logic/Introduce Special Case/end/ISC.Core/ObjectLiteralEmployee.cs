namespace ISC.Core
{
    public class ObjectLiteralEmployee
    {
        private readonly IObjectLiteralJob _job;

        public ObjectLiteralEmployee(IObjectLiteralJob job)
        {
            _job = job;
        }

        public IObjectLiteralJob Job
        {
            get
            {
                if (_job.Name == "Unassigned")
                {
                    return ObjectLiteralFactory.CreateUnassignedJob();
                }

                return _job;
            }
        }
    }
}
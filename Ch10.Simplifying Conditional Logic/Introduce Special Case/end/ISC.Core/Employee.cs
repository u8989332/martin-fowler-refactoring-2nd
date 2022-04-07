namespace ISC.Core
{
    public class Employee
    {
        private readonly Job _job;

        public Employee(Job job)
        {
            _job = job;
        }

        public Job Job
        {
            get
            {
                if (_job.Name == "Unassigned")
                {
                    return new UnassignedJob();
                }

                return _job;
            }
        }
    }
}
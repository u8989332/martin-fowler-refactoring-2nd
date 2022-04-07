namespace ISC.Core
{
    public class TransformExample
    {
        public static string GetJobName(TransformEmployee emp)
        {
            TransformJob job = emp.Job;
            string jobName;
            if (job.Name == "Unassigned")
            {
                jobName = "Intern";
            }
            else
            {
                jobName = job.Name;
            }

            return jobName;
        }

        public static string GetBonusPlan(TransformEmployee emp)
        {
            if (emp.Job.Name == "Unassigned")
            {
                return "New Plan";
            }

            return emp.Job.BonusPlan;
        }

        public static int GetSalaryBaseAmount(TransformEmployee emp)
        {
            if (emp.Job.Name == "Unassigned")
            {
                return 0;
            }

            return emp.Job.Salary.BaseAmount;
        }
    }
}
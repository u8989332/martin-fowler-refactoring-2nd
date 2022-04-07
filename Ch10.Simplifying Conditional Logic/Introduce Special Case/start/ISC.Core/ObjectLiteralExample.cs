namespace ISC.Core
{
    public class ObjectLiteralExample
    {
        public static string GetJobName(ObjectLiteralEmployee emp)
        {
            ObjectLiteralJob job = emp.Job;
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

        public static string GetBonusPlan(ObjectLiteralEmployee emp)
        {
            if (emp.Job.Name == "Unassigned")
            {
                return "New Plan";
            }

            return emp.Job.BonusPlan;
        }

        public static int GetSalaryBaseAmount(ObjectLiteralEmployee emp)
        {
            if (emp.Job.Name == "Unassigned")
            {
                return 0;
            }

            return emp.Job.Salary.BaseAmount;
        }
    }
}
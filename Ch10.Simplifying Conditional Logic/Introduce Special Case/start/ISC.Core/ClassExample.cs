namespace ISC.Core
{
    public class ClassExample
    {
        public static string GetJobName(Employee emp)
        {
            Job job = emp.Job;
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

        public static string GetBonusPlan(Employee emp)
        {
            if (emp.Job.Name == "Unassigned")
            {
                return "New Plan";
            }

            return emp.Job.BonusPlan;
        }

        public static void SetBonusPlan(Employee emp, string newBonusPlan)
        {
            if (emp.Job.Name != "Unassigned")
            {
                emp.Job.BonusPlan = newBonusPlan;
            }
        }

        public static int GetSalaryBaseAmount(Employee emp)
        {
            if (emp.Job.Name == "Unassigned")
            {
                return 0;
            }

            return emp.Job.Salary.BaseAmount;
        }
    }
}
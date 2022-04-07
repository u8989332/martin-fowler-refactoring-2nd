namespace ISC.Core
{
    public class ClassExample
    {
        public static string GetJobName(Employee emp)
        {
            Job job = emp.Job;
            return job.Name;
        }

        public static string GetBonusPlan(Employee emp)
        {
            return emp.Job.BonusPlan;
        }

        public static void SetBonusPlan(Employee emp, string newBonusPlan)
        {
            emp.Job.BonusPlan = newBonusPlan;
        }

        public static int GetSalaryBaseAmount(Employee emp)
        {
            return emp.Job.Salary.BaseAmount;
        }
    }
}
namespace ISC.Core
{
    public class ObjectLiteralExample
    {
        public static string GetJobName(ObjectLiteralEmployee emp)
        {
            IObjectLiteralJob job = emp.Job;
            return job.Name;
        }

        public static string GetBonusPlan(ObjectLiteralEmployee emp)
        {
            return emp.Job.BonusPlan;
        }

        public static int GetSalaryBaseAmount(ObjectLiteralEmployee emp)
        {
            return emp.Job.Salary.BaseAmount;
        }
    }
}
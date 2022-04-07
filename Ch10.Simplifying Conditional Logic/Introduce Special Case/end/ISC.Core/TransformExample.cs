namespace ISC.Core
{
    public class TransformExample
    {
        public static string GetJobName(TransformEmployee emp)
        {
            var enrichedEmp = EnrichEmp(emp);
            var job = enrichedEmp.Job;
            return job.Name;
        }

        public static string GetBonusPlan(TransformEmployee emp)
        {
            var enrichedEmp = EnrichEmp(emp);
            return enrichedEmp.Job.BonusPlan;
        }

        public static int GetSalaryBaseAmount(TransformEmployee emp)
        {
            var enrichedEmp = EnrichEmp(emp);
            return enrichedEmp.Job.Salary.BaseAmount;
        }

        private static TransformEmployee EnrichEmp(TransformEmployee emp)
        {
            var result = new TransformEmployee(emp);
            if (IsUnassigned(result.Job))
            {
                result.Job = new TransformUnassignedJob();
            }
            else
            {
                result.Job.IsUnassigned = false;
            }

            return result;
        }

        private static bool IsUnassigned(ITransformJob job)
        {
            if (job.Name == "Unassigned")
            {
                return true;
            }

            return job.IsUnassigned;
        }
    }
}
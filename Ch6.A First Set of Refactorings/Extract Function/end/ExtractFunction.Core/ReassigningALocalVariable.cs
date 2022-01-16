using System;

namespace ExtractFunction.Core
{
    public class ReassigningALocalVariable
    {
        private readonly IClock _clock;

        public ReassigningALocalVariable(IClock clock)
        {
            _clock = clock;
        }

        public void PrintWorkLoading(WorkLoading workLoading)
        {
            PrintBanner();
            var allProgress = CalculateAllProgress(workLoading);
            RecordDueDate(workLoading);
            PrintDetails(workLoading, allProgress);
        }

        private int CalculateAllProgress(WorkLoading workLoading)
        {
            int result = 0;
            foreach (var project in workLoading.Projects)
            {
                result += project.Progress;
            }

            return result;
        }

        private void RecordDueDate(WorkLoading workLoading)
        {
            var today = _clock.Now;
            workLoading.DueDate = today.AddDays(30);
        }

        private void PrintDetails(WorkLoading workLoading, int allProgress)
        {
            Console.WriteLine($"name: {workLoading.Name}");
            Console.WriteLine($"progress: {allProgress}");
            Console.WriteLine($"due: {workLoading.DueDate:MM/dd/yyyy}");
        }

        private static void PrintBanner()
        {
            Console.WriteLine("*************");
            Console.WriteLine("** Loading **");
            Console.WriteLine("*************");
        }
    }
}
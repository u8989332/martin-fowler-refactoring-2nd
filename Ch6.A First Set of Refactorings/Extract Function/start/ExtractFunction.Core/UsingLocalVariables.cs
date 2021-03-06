using System;

namespace ExtractFunction.Core
{
    public class UsingLocalVariables
    {
        private readonly IClock _clock;

        public UsingLocalVariables(IClock clock)
        {
            _clock = clock;
        }

        public void PrintWorkLoading(WorkLoading workLoading)
        {
            int allProgress = 0;

            PrintBanner();

            // calculate progress
            foreach (var project in workLoading.Projects)
            {
                allProgress += project.Progress;
            }

            // record due date
            var today = _clock.Now;
            workLoading.DueDate = today.AddDays(30);

            // print details
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

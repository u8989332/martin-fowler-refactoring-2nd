using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitLoop.Core
{
    public class ASimpleExample
    {
        public static string GetExamResult()
        {
            List<Student> students = new List<Student>()
            {
                new Student(90),
                new Student(45),
                new Student(88),
                new Student(54)
            };

            return $"Highest score: {HighestScore(students)}, total score: {TotalScore(students)}";
        }

        private static int HighestScore(List<Student> students)
        {
            return students.Select(student => student.ScienceExamScore).Max();
        }

        private static int TotalScore(List<Student> students)
        {
            return students.Sum(student => student.ScienceExamScore);
        }
    }
}

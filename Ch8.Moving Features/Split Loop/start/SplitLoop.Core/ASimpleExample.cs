using System;
using System.Collections.Generic;

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

            int totalScore = 0;
            int highestScore = int.MinValue;
            foreach (var student in students)
            {
                if (student.ScienceExamScore > highestScore)
                {
                    highestScore = student.ScienceExamScore;
                }

                totalScore += student.ScienceExamScore;
            }

            return $"Highest score: {highestScore}, total score: {totalScore}";
        }
    }
}

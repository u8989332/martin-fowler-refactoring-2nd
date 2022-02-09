using System.Collections.Generic;

namespace EncapsulateRecord.Core
{
    public class EncapsulatingANestedRecordExample
    {
        private static CourseWrap course = new CourseWrap(new Course()
        {
            {
                "CS195", new CourseDetail()
                {
                    Id = "CS195",
                    Name = "Algorithms",
                    Teachers = new Dictionary<string, Dictionary<string, int>>()
                    {
                        {
                            "John", new Dictionary<string, int>()
                            {
                                {"Publications", 70},
                                {"Citations", 60},
                                {"ResearchIncome", 65}
                            }
                        },
                        {
                            "Mary", new Dictionary<string, int>()
                            {
                                {"Publications", 79},
                                {"Citations", 64},
                                {"ResearchIncome", 75}
                            }
                        }
                    }
                }
            },
            {
                "MATH203", new CourseDetail()
                {
                    Id = "MATH203",
                    Name = "Calculus",
                    Teachers = new Dictionary<string, Dictionary<string, int>>()
                    {
                        {
                            "Tom", new Dictionary<string, int>()
                            {
                                {"Publications", 62},
                                {"Citations", 88},
                                {"ResearchIncome", 75}
                            }
                        },
                        {
                            "Sherry", new Dictionary<string, int>()
                            {
                                {"Publications", 61},
                                {"Citations", 75},
                                {"ResearchIncome", 85}
                            }
                        }
                    }
                }
            }
        });

        public static void UpdateResearchPerformance(string courseId, string teacherId,
            string performanceName, int performanceScore)
        {
            GetCourse().SetPerformanceScore(courseId, teacherId, performanceName, performanceScore);
        }

        public static int GetTotalPerformanceScores(string courseId, string teacherId)
        {
            return GetCourse().GetTotalPerformanceScore(courseId, teacherId);
        }

        private static CourseWrap GetCourse()
        {
            return course;
        }

        private static void SetRawDataOfCourse(Course data)
        {
            course = new CourseWrap(data);
        }
    }
}

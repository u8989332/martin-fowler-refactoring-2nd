namespace CCE.Core
{
    public class UsingAndsExample
    {
        public static int SummerCampPrice(Student student)
        {
            if (DiscountSummerCampPrice(student))
            {
                return 500;
            }

            return 1000;
        }

        private static bool DiscountSummerCampPrice(Student student)
        {
            return student.GoodActionCount > 2 && student.ExamGrade > 80;
        }
    }
}
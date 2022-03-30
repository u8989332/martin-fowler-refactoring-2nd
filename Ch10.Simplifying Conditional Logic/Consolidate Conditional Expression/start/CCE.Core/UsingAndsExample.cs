namespace CCE.Core
{
    public class UsingAndsExample
    {
        public static int SummerCampPrice(Student student)
        {
            if (student.GoodActionCount > 2)
            {
                if(student.ExamGrade > 80)
                {
                    return 500;
                }
            }

            return 1000;
        }
    }
}
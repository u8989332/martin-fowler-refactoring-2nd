namespace CCE.Core
{
    public class Student
    {
        public Student(int goodActionCount, int examGrade)
        {
            GoodActionCount = goodActionCount;
            ExamGrade = examGrade;
        }

        public int GoodActionCount { get; }
        public int ExamGrade { get; }
    }
}
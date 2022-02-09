namespace EncapsulateRecord.Core
{
    public class SimpleRecordExample
    {
        private static StudentWrap student = new StudentWrap(new Student()
        {
            Name = "John",
            Grade = 6
        });

        public static string UpdateStudentName(string newName)
        {
            string result = $"The original name: {GetStudent().Name}\n";
            GetStudent().Name = newName;
            result += $"The updated name: {GetStudent().Name}";

            return result;
        }

        private static StudentWrap GetStudent()
        {
            return student;
        }
    }
}
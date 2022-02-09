namespace EncapsulateRecord.Core
{
    public class SimpleRecordExample
    {
        private static Student student = new Student()
        {
            Name = "John",
            Grade = 6
        };

        public static string UpdateStudentName(string newName)
        {
            string result = $"The original name: {student.Name}\n";
            student.Name = newName;
            result += $"The updated name: {student.Name}";

            return result;
        }
    }
}

namespace EncapsulateRecord.Core
{
    public class StudentWrap
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public StudentWrap(Student data)
        {
            Name = data.Name;
            Grade = data.Grade;
        }
    }
}
using System.Collections.Generic;

namespace EncapsulateRecord.Core
{
    public class Course : Dictionary<string, CourseDetail>
    {
        public Course() : base()
        {

        }

        public Course(IDictionary<string, CourseDetail> dictionary) : base(dictionary)
        {
        }
    }
}

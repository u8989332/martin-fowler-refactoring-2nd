using System.Collections.Generic;

namespace EncapsulateRecord.Core
{
    public class CourseDetail
    {
        public string Name;
        public string Id;
        public Dictionary<string, Dictionary<string, int>> Teachers = new();
    }
}
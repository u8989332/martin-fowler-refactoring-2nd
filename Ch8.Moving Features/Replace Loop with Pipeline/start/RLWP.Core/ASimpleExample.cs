using System.Collections.Generic;

namespace RLWP.Core
{
    public class ASimpleExample
    {
        public static List<Student> GetHighHeightStudentsFromCsv()
        {
            const string studentCsv =
                @"name, id, id
Jack, 1, 170
Mary, 2, 145
Billy, 3, 181
Hank, 4, 164
Jessie, 5, 168
";
            var lines = studentCsv.Split('\n');
            List<Student> result = new List<Student>();
            bool firstLine = true;
            foreach (var line in lines)
            {
                if (firstLine)
                {
                    firstLine = false;
                    continue;
                }

                if (line.Trim() == "")
                {
                    continue;
                }

                var record = line.Split(',');
                if (int.Parse(record[2].Trim()) > 165)
                {
                    result.Add(new Student(record[0].Trim(), record[1].Trim()));
                }
            }

            return result;
        }
    }
}
using System.Collections.Generic;
using System.Linq;

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
            List<Student> result = lines
                .Skip(1)
                .Where(line => line.Trim() != "")
                .Select(line => line.Split(','))
                .Where(record => int.Parse(record[2].Trim()) > 165)
                .Select(record => new Student(record[0].Trim(), record[1].Trim()))
                .ToList();

            return result;
        }
    }
}

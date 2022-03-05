using System;

namespace MoveField.Core
{
    public class Student
    {
        private string _name;
        private int _conductGrade;
        private StudentTranscript _transcript;

        public int ConductGrade => _conductGrade;

        public Student(string name, int conductGrade)
        {
            _name = name;
            _conductGrade = conductGrade;
            _transcript = new StudentTranscript(DateTime.Now);
        }

        public void GoodPerformance()
        {
            _conductGrade += 2;
        }

        public string DisplayConductGrade(string schoolName)
        {
            return $"{schoolName}, {_name}'s conduct grade: {_conductGrade}";
        }
    }
}

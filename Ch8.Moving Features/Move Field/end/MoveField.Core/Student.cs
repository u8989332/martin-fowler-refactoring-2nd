using System;

namespace MoveField.Core
{
    public class Student
    {
        private string _name;
        private StudentTranscript _transcript;

        public int ConductGrade
        {
            get => _transcript.ConductGrade;
            set => _transcript.ConductGrade = value;
        }
        

        public Student(string name, int conductGrade)
        {
            _name = name;
            _transcript = new StudentTranscript(DateTime.Now);
            ConductGrade = conductGrade;
        }

        public void GoodPerformance()
        {
            ConductGrade += 2;
        }

        public string DisplayConductGrade(string schoolName)
        {
            return $"{schoolName}, {_name}'s conduct grade: {ConductGrade}";
        }
    }
}

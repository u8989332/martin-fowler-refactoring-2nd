using System;

namespace MoveField.Core
{
    public class StudentTranscript
    {
        private DateTime _contestDate;
        private int _conductGrade;

        public StudentTranscript(DateTime contestDate, int conductGrade = default)
        {
            _contestDate = contestDate;
            _conductGrade = conductGrade;
        }

        public int ConductGrade
        {
            get => _conductGrade;
            set => _conductGrade = value;
        }
    }
}
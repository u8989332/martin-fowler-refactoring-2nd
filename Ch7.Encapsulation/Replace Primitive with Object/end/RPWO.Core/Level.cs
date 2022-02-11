using System;
using System.Collections.Generic;

namespace RPWO.Core
{
    public class Level
    {
        private static readonly List<string> LegalValues = new List<string>(){"C", "B", "A", "S"};
        private string _value;

        public Level(string value)
        {
            if (!LegalValues.Contains(value))
            {
                throw new Exception("value is invalid for Level");
            }

            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }

        private int Index => LegalValues.IndexOf(_value);

        public bool Equals(Level obj)
        {
            return Index == obj.Index;
        }

        public bool HigherThan(Level obj)
        {
            return Index > obj.Index;
        }

        public bool LowerThan(Level obj)
        {
            return Index < obj.Index;
        }
    }
}
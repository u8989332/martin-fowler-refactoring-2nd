namespace MoveField.Core
{
    public class EmployeeTitle
    {
        private string _name;
        private int _baseLeaves;

        public EmployeeTitle(string name, int baseLeaves)
        {
            _name = name;
            _baseLeaves = baseLeaves;
        }

        public int BaseLeaves => _baseLeaves;
    }
}
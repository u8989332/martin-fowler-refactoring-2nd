namespace MoveField.Core
{
    public class Employee
    {
        private string _name;
        private EmployeeTitle _title;
        private int _baseLeaves;

        public Employee(string name, EmployeeTitle title, int baseLeaves)
        {
            _name = name;
            _title = title;
            _baseLeaves = baseLeaves;
        }

        public int BaseLeaves => _baseLeaves;
    }
}

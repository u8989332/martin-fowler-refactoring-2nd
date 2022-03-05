namespace MoveField.Core
{
    public class Employee
    {
        private string _name;
        private EmployeeTitle _title;

        public Employee(string name, EmployeeTitle title)
        {
            _name = name;
            _title = title;
        }

        public int BaseLeaves => _title.BaseLeaves;
    }
}

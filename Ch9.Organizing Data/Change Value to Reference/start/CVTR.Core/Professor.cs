namespace CVTR.Core
{
    public class Professor
    {
        private readonly string _name;

        public Professor(string name, int departmentId)
        {
            _name = name;
            Department = new Department(departmentId);
        }

        public Department Department { get; }
    }
}

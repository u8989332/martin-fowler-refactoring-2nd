namespace CVTR.Core
{
    public class Professor
    {
        private readonly string _name;

        public Professor(string name, int departmentId)
        {
            _name = name;
            Department = Repository.RegisterDepartment(departmentId);
        }

        public Department Department { get; }
    }
}

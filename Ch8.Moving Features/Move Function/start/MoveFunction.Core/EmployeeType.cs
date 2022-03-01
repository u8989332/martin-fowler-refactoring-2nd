namespace MoveFunction.Core
{
    public class EmployeeType
    {
        public EmployeeType(bool isManager)
        {
            IsManager = isManager;
        }

        public bool IsManager { get; }
    }
}
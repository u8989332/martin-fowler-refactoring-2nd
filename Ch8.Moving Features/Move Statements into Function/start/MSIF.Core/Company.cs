namespace MSIF.Core
{
    public class Company
    {
        public Company(string name, Employee ceo)
        {
            Name = name;
            CEO = ceo;
        }

        public string Name { get; }
        public Employee CEO { get; }
    }
}
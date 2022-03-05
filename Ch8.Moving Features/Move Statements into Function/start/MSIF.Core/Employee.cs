using System;

namespace MSIF.Core
{
    public class Employee
    {
        public Employee(string name, string title, DateTime dateOfEmployment)
        {
            Name = name;
            Title = title;
            DateOfEmployment = dateOfEmployment;
        }

        public string Name { get; }
        public string Title { get; }
        public DateTime DateOfEmployment { get; }
    }
}
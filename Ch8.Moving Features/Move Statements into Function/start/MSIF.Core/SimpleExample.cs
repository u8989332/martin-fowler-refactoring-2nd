using System;
using System.Collections.Generic;

namespace MSIF.Core
{
    public class SimpleExample
    {
        private static readonly Employee _employee = new Employee(
            "Lucy",
            "CEO",
            new DateTime(2022, 1, 2));

        public static string GetCompany()
        {
            Company com = new Company(
                "NextGeneration", 
                _employee);

            return DisplayCompany(com);
        }

        public static string GetCEO()
        {
            return HighlightCEO(_employee);
        }

        private static string DisplayCompany(Company com)
        {
            List<string> result = new List<string>();
            result.Add($"Name: {com.Name}");
            result.Add($"CEO Name: {com.CEO.Name}");
            result.Add(DisplayCEO(com.CEO));
            return string.Join('\n', result);
        }

        private static string HighlightCEO(Employee ceo)
        {
            return "This is our CEO!\n" + $"CEO Name: {ceo.Name}\n" + DisplayCEO(ceo);
        }

        private static string DisplayCEO(Employee ceo)
        {
            List<string> result = new List<string>();
            result.Add($"CEO Title: {ceo.Title}");
            result.Add($"Date of employment: {ceo.DateOfEmployment:yyyy/MM/dd}");
            return string.Join('\n', result);
        }
    }
}

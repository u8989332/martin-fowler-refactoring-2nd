using NUnit.Framework;
using RTWQ.Core;

namespace RTWQ.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_SimpleExample_Get_Correct_Bonus()
        {
            // arrange
            double companyPerformance = 0.1;
            Salary salary1 = new Salary(companyPerformance, new Employee() { AnnualSalary = 60000 });
            Salary salary2 = new Salary(companyPerformance, new Employee() { AnnualSalary = 100000.50 });

            // act
            double result1 = salary1.Bonus;
            double result2 = salary2.Bonus;

            // assert
            Assert.AreEqual(6300, result1, 0.01);
            Assert.AreEqual(10200.05, result2, 0.01);
        }
    }
}
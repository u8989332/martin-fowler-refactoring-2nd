using System;
using DecomposeConditional.Core;
using NUnit.Framework;

namespace DecomposeConditional.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_2_Employees_Return_Correct_Bonus()
        {
            // arrange
            AnnualBonusPlan plan = new AnnualBonusPlan(new DateTime(2020, 1, 1), 0.05, 0.2);
            Employee emp1 = new Employee(new DateTime(2021, 5, 4), 64215.6, plan);
            Employee emp2 = new Employee(new DateTime(2014, 11, 22), 97518.48, plan);

            // act
            double result1 = emp1.Bonus();
            double result2 = emp2.Bonus();

            // assert
            Assert.AreEqual(3210.78, result1, 0.01);
            Assert.AreEqual(19503.69, result2, 0.01);
        }
    }
}
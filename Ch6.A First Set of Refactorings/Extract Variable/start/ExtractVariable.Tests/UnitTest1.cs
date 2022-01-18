using ExtractVariable.Core;
using NUnit.Framework;

namespace ExtractVariable.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Use_StaticFunctionExample_Return_Correct_Bonus()
        {
            // arrange
            EmployeeForStaticFunction emp1 = new EmployeeForStaticFunction(5, 52000.60, 2);
            EmployeeForStaticFunction emp2 = new EmployeeForStaticFunction(12, 82115.69, 6);

            // act
            double result1 = StaticFunctionExample.Bonus(emp1);
            double result2 = StaticFunctionExample.Bonus(emp2);

            // assert
            Assert.AreEqual(13000.15, result1, 0.01);
            Assert.AreEqual(57480.98, result2, 0.01);
        }

        [Test]
        public void Use_InAClassEmployeeExample_Return_Correct_Bonus()
        {
            // arrange
            EmployeeRecord emp1 = new EmployeeRecord(5, 52000.60, 2);
            EmployeeRecord emp2 = new EmployeeRecord(12, 82115.69, 6);

            // act
            double result1 = new InAClassEmployeeExample(emp1).Bonus;
            double result2 = new InAClassEmployeeExample(emp2).Bonus;

            // assert
            Assert.AreEqual(13000.15, result1, 0.01);
            Assert.AreEqual(57480.98, result2, 0.01);
        }
    }
}
using ISC.Core;
using NUnit.Framework;

namespace ISC.Tests
{
    public class ObjectLiteralExampleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_ObjectLiteralExample_GetJobName_Return_Correct_Name()
        {
            // arrange
            ObjectLiteralEmployee emp1 = new ObjectLiteralEmployee(new ObjectLiteralJob("Software Engineer", new ObjectLiteralSalary(5000)));
            ObjectLiteralEmployee emp2 = new ObjectLiteralEmployee(new ObjectLiteralJob("Unassigned"));

            // act
            string result1 = ObjectLiteralExample.GetJobName(emp1);
            string result2 = ObjectLiteralExample.GetJobName(emp2);

            // assert
            Assert.AreEqual("Software Engineer", result1);
            Assert.AreEqual("Intern", result2);
        }

        [Test]
        public void Call_ObjectLiteralExample_GetBonusPlan_Return_Correct_Plan()
        {
            // arrange
            ObjectLiteralEmployee emp1 = new ObjectLiteralEmployee(new ObjectLiteralJob("Software Engineer", new ObjectLiteralSalary(5000))
            {
                BonusPlan = "Old Plan"
            });
            ObjectLiteralEmployee emp2 = new ObjectLiteralEmployee(new ObjectLiteralJob("Unassigned"));

            // act
            string result1 = ObjectLiteralExample.GetBonusPlan(emp1);
            string result2 = ObjectLiteralExample.GetBonusPlan(emp2);

            // assert
            Assert.AreEqual("Old Plan", result1);
            Assert.AreEqual("New Plan", result2);
        }

        [Test]
        public void Call_ObjectLiteralExample_GetSalaryBaseAmount_Return_Correct_Amount()
        {
            // arrange
            ObjectLiteralEmployee emp1 = new ObjectLiteralEmployee(new ObjectLiteralJob("Software Engineer", new ObjectLiteralSalary(5000)));
            ObjectLiteralEmployee emp2 = new ObjectLiteralEmployee(new ObjectLiteralJob("Unassigned"));

            // act
            int result1 = ObjectLiteralExample.GetSalaryBaseAmount(emp1);
            int result2 = ObjectLiteralExample.GetSalaryBaseAmount(emp2);

            // assert
            Assert.AreEqual(5000, result1);
            Assert.AreEqual(0, result2);
        }
    }
}
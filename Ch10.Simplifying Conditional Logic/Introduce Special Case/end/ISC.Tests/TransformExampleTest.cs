using ISC.Core;
using NUnit.Framework;

namespace ISC.Tests
{
    public class TransformExampleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_TransformExample_GetJobName_Return_Correct_Name()
        {
            // arrange
            TransformEmployee emp1 = new TransformEmployee(new TransformJob("Software Engineer", new TransformSalary(5000)));
            TransformEmployee emp2 = new TransformEmployee(new TransformJob("Unassigned"));

            // act
            string result1 = TransformExample.GetJobName(emp1);
            string result2 = TransformExample.GetJobName(emp2);

            // assert
            Assert.AreEqual("Software Engineer", result1);
            Assert.AreEqual("Intern", result2);
        }

        [Test]
        public void Call_TransformExample_GetBonusPlan_Return_Correct_Plan()
        {
            // arrange
            TransformEmployee emp1 = new TransformEmployee(new TransformJob("Software Engineer", new TransformSalary(5000))
            {
                BonusPlan = "Old Plan"
            });
            TransformEmployee emp2 = new TransformEmployee(new TransformJob("Unassigned"));

            // act
            string result1 = TransformExample.GetBonusPlan(emp1);
            string result2 = TransformExample.GetBonusPlan(emp2);

            // assert
            Assert.AreEqual("Old Plan", result1);
            Assert.AreEqual("New Plan", result2);
        }

        [Test]
        public void Call_TransformExample_GetSalaryBaseAmount_Return_Correct_Amount()
        {
            // arrange
            TransformEmployee emp1 = new TransformEmployee(new TransformJob("Software Engineer", new TransformSalary(5000)));
            TransformEmployee emp2 = new TransformEmployee(new TransformJob("Unassigned"));

            // act
            int result1 = TransformExample.GetSalaryBaseAmount(emp1);
            int result2 = TransformExample.GetSalaryBaseAmount(emp2);

            // assert
            Assert.AreEqual(5000, result1);
            Assert.AreEqual(0, result2);
        }
    }
}
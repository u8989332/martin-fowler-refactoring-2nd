using ISC.Core;
using NUnit.Framework;

namespace ISC.Tests
{
    public class ClassExampleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_ClassExample_GetJobName_Return_Correct_Name()
        {
            // arrange
            Employee emp1 = new Employee(new Job("Software Engineer", new Salary(5000)));
            Employee emp2 = new Employee(new Job("Unassigned"));

            // act
            string result1 = ClassExample.GetJobName(emp1);
            string result2 = ClassExample.GetJobName(emp2);

            // assert
            Assert.AreEqual("Software Engineer", result1);
            Assert.AreEqual("Intern", result2);
        }

        [Test]
        public void Call_ClassExample_GetBonusPlan_Return_Correct_Plan()
        {
            // arrange
            Employee emp1 = new Employee(new Job("Software Engineer", new Salary(5000))
            {
                BonusPlan = "Old Plan"
            });
            Employee emp2 = new Employee(new Job("Unassigned"));

            // act
            string result1 = ClassExample.GetBonusPlan(emp1);
            string result2 = ClassExample.GetBonusPlan(emp2);

            // assert
            Assert.AreEqual("Old Plan", result1);
            Assert.AreEqual("New Plan", result2);
        }

        [Test]
        public void Call_ClassExample_SetBonusName_Return_Update_Plan()
        {
            // arrange
            Employee emp1 = new Employee(new Job("Software Engineer", new Salary(5000)));
            Employee emp2 = new Employee(new Job("Unassigned"));

            // act
            ClassExample.SetBonusPlan(emp1, "My New Plan");
            ClassExample.SetBonusPlan(emp2, "Test");

            // assert
            Assert.AreEqual("My New Plan", emp1.Job.BonusPlan);
            Assert.AreEqual("New Plan", emp2.Job.BonusPlan);
        }

        [Test]
        public void Call_ClassExample_GetSalaryBaseAmount_Return_Correct_Amount()
        {
            // arrange
            Employee emp1 = new Employee(new Job("Software Engineer", new Salary(5000)));
            Employee emp2 = new Employee(new Job("Unassigned"));

            // act
            int result1 = ClassExample.GetSalaryBaseAmount(emp1);
            int result2 = ClassExample.GetSalaryBaseAmount(emp2);

            // assert
            Assert.AreEqual(5000, result1);
            Assert.AreEqual(0, result2);
        }
    }
}
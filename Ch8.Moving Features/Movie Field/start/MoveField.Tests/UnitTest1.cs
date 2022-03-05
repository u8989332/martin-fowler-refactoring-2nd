using MoveField.Core;
using NUnit.Framework;

namespace MoveField
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_Simple_Example_Can_Return_Correct_Result()
        {
            // arrange
            Student stu = new Student("Billy", 60);

            // act
            stu.GoodPerformance();
            string resultForDisplay = stu.DisplayConductGrade("Happy University");
            int resultForGrade = stu.ConductGrade;

            // assert
            Assert.AreEqual("Happy University, Billy's conduct grade: 62", resultForDisplay);
            Assert.AreEqual(62, resultForGrade);
        }

        [Test]
        public void Call_MovingToASharedObject_Can_Return_Correct_Result()
        {
            // arrange
            EmployeeTitle title = new EmployeeTitle("Manager");
            Employee emp = new Employee("Jack", title, 10);

            // act
            int result = emp.BaseLeaves;

            // assert
            Assert.AreEqual(10, result);
        }
    }
}
using CVTR.Core;
using NUnit.Framework;

namespace CVTR.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_2_Professors_With_Same_Department_Return_Same_Id_and_Same_Instance()
        {
            // arrange
            Professor p1 = new Professor("Jerry", 1);
            Professor p2 = new Professor("Jessie", 1);

            // act
            bool sameDepartmentId = p1.Department.Id == p2.Department.Id;
            bool sameDepartmentInstances = p1.Department.Equals(p2.Department);

            // assert
            Assert.IsTrue(sameDepartmentId);
            Assert.IsTrue(sameDepartmentInstances);
        }
    }
}
using CRTV.Core;
using NUnit.Framework;

namespace CRTV.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Set_Student_Data_And_Get_Correct_Value()
        {
            // arrange
            Student stu = new Student()
            {
                AddressCity = "Taipei",
                AddressStreet = "ChungHuaRoad"
            };

            // act
            string city = stu.AddressCity;
            string street = stu.AddressStreet;

            // assert
            Assert.AreEqual("Taipei", city);
            Assert.AreEqual("ChungHuaRoad", street);

        }
    }
}
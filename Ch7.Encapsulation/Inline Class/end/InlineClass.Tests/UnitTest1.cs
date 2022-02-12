using InlineClass.Core;
using NUnit.Framework;

namespace InlineClass.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // arrange
            School school = new School()
            {
                PrincipalName = "John",
                PrincipalOffice = "Computer Avenue Room 4-111"
            };

            // act
            school.PrincipalName = "Jack";
            string result = school.PrincipalInfo;

            // assert
            Assert.AreEqual("Computer Avenue Room 4-111 : Jack", result);
        }
    }
}
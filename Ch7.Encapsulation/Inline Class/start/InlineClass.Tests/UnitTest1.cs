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
                Principal = new Principal()
                {
                    Name = "John",
                    Office = "Computer Avenue Room 4-111"
                }
            };

            // act
            school.Principal.Name = "Jack";
            string result = school.PrincipalInfo;

            // assert
            Assert.AreEqual("Computer Avenue Room 4-111 : Jack", result);
        }
    }
}
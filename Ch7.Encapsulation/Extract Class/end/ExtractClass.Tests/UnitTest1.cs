using ExtractClass.Core;
using NUnit.Framework;

namespace ExtractClass.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Create_Company_Return_Correct_Office()
        {
            // arrange
            Company company = new Company()
            {
                Name = "HappyInc",
                OfficeCountry = "Taiwan",
                OfficeRoad = "DaLi Road"
            };

            // act
            string result = company.Office;

            // assert
            Assert.AreEqual("Taiwan DaLi Road", result);
        }
    }
}
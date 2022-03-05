using MSIF.Core;
using NUnit.Framework;

namespace MSIF.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_SimpleExample_Return_Correct_Result()
        {
            // act
            string resultForCompany = SimpleExample.GetCompany();
            string resultForCEO = SimpleExample.GetCEO();

            // assert
            Assert.AreEqual("Name: NextGeneration\nCEO Name: Lucy\nCEO Title: CEO\nDate of employment: 2022/01/02", resultForCompany);
            Assert.AreEqual("This is our CEO!\nCEO Name: Lucy\nCEO Title: CEO\nDate of employment: 2022/01/02", resultForCEO);
        }
    }
}
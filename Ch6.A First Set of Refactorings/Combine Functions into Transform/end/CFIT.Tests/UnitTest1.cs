using CFIT.Core;
using NUnit.Framework;

namespace CFIT.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Get_Some_Employee_SalaryBonusTax_Correctly()
        {
            // arrange & act
            double result = SalaryBonusExample.GetSalaryBonusTax();

            // act
            Assert.AreEqual(3900.03, result, 0.01);
        }
    }
}
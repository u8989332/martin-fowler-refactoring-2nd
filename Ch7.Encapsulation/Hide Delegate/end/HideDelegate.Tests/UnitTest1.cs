using HideDelegate.Core;
using NUnit.Framework;

namespace HideDelegate.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_Order_Customer_Return_Correct_Name()
        {
            // arrange
            Order order = new Order("Test");

            // act
            string result = order.CustomerName;

            // assert
            Assert.AreEqual("Jack", result);
        }
    }
}
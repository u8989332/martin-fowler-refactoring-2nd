using MoveFunction.Core;
using NUnit.Framework;

namespace MoveFunction.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_MovingANestedFunctionToTopLevelExample_Return_Correct_Result()
        {
            // arrange
            Product[] products = new Product[]
            {
                new Product(9000),
                new Product(4500),
                new Product(45647.59)
            };

            // act
            var result = MovingANestedFunctionToTopLevelExample.CalculateOrderSummary(products);

            // assert
            Assert.AreEqual(50725.45, result.TotalPrice, 0.01);
            Assert.AreEqual(16908.48, result.AveragePrice, 0.01);
        }

        [Test]
        public void Call_MovingBetweenClassesExample_Return_Correct_Result()
        {
            // arrange
            // act
            var result = MovingBetweenClassesExample.GetAnnualLeaves();

            // assert
            Assert.AreEqual(12, result.Emp1);
            Assert.AreEqual(7, result.Emp2);
        }
    }
}
using System.Collections.Generic;
using NUnit.Framework;
using SplitVariable.Core;

namespace SplitVariable.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_ASimpleExample_Return_Correct_Result()
        {
            // arrange
            var order = new Order(100, 60, new List<Product>()
            {
                new Product(600),
                new Product(999),
                new Product(547)
            });

            // act
            double result = ASimpleExample.Discount(order);

            // assert
            Assert.AreEqual(334.6, result, 0.01);
        }

        [Test]
        public void Call_AssigningToAnInputParameter_Return_Correct_Result()
        {
            // act
            double result = AssigningToAnInputParameter.KPI(9, 3);

            // assert
            Assert.AreEqual(10, result);
        }
    }
}
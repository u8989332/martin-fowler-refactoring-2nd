using EncapsulateCollection.Core;
using NUnit.Framework;

namespace EncapsulateCollection.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_Order_Update_And_GetCount_Return_Correct()
        {
            // arrange
            // act

            int firstCount = SimpleExample.GerHighPriceProductCount();

            SimpleExample.UpdateProducts();
            int nextCount = SimpleExample.GerHighPriceProductCount();

            SimpleExample.AddHighPriceProduct();
            int finalCount = SimpleExample.GerHighPriceProductCount();

            // assert
            Assert.AreEqual(2, firstCount);
            Assert.AreEqual(1, nextCount);
            Assert.AreEqual(2, finalCount);
        }
    }
}
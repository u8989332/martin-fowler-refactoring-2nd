using InlineFunction.Core;
using NUnit.Framework;

namespace InlineFunction.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void A_Man_Rating_Is_Correct()
        {
            // arrange
            Man man = new Man()
            {
                Money = 999999
            };

            // act
            int result = RatingExample.Rating(man);

            // assert
            Assert.AreEqual(80, result);
        }

        [Test]
        public void A_Product_Report_Lines_Is_Correct()
        {
            // arrange
            Product product = new Product()
            {
                Name = "Doll",
                Vendor = "Johnny Factory"
            };

            // act
            var result = ReportLinesExample.ReportLines(product);

            // assert
            Assert.AreEqual("name", result[0].Key);
            Assert.AreEqual("Doll", result[0].Value);
            Assert.AreEqual("vendor", result[1].Key);
            Assert.AreEqual("Johnny Factory", result[1].Value);
        }
    }
}
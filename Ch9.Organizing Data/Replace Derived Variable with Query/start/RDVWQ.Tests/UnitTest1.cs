using NUnit.Framework;
using RDVWQ.Core;

namespace RDVWQ.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_ASimpleExample_Can_Return_Correct_Result()
        {
            // arrange
            ASimpleExample shopping = new ASimpleExample();

            // act
            shopping.AddCreditAfterShopping(new Product(5));
            shopping.AddCreditAfterShopping(new Product(6));
            shopping.AddCreditAfterShopping(new Product(10));

            // assert
            Assert.AreEqual(21, shopping.Credit);
        }

        [Test]
        public void Call_MoreThanOneSourceExample_Can_Return_Correct_Result()
        {
            // arrange
            MoreThanOneSourceExample shopping = new MoreThanOneSourceExample(30);

            // act
            shopping.AddCreditAfterShopping(new Product(7));
            shopping.AddCreditAfterShopping(new Product(9));
            shopping.AddCreditAfterShopping(new Product(13));

            // assert
            Assert.AreEqual(59, shopping.Credit);
        }
    }
}
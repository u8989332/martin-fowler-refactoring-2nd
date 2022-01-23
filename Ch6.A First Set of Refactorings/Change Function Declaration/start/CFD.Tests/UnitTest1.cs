using CFD.Core;
using NUnit.Framework;

namespace CFD.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_RenameAFunctionSimpleExample_Return_Correct_Seconds()
        {
            // arrange
            int days = 5;

            // act.
            int result = RenameAFunctionSimpleExample.Seconds(days);

            // assert
            Assert.AreEqual(432000, result);
        }

        [Test]
        public void Call_RenameAFunctionMigrationExample_Return_Correct_Seconds()
        {
            // arrange
            int days = 5;

            // act.
            int result = RenameAFunctionMigrationExample.Seconds(days);

            // assert
            Assert.AreEqual(432000, result);
        }

        [Test]
        public void Call_AddingAParameterExample_No_Error()
        {
            // arrange
            Product p = new Product();

            // act
            AddingAParameterExample.AddShoppingCart(p);

            // assert
            Assert.Pass();
        }

        [Test]
        public void Call_ChangingAParameterToOneOfItsPropertiesExample_Return_Correct_LuckyPerson()
        {
            // arrange
            Member member1 = new Member()
            {
                ZodiacSign = new ZodiacSign()
                {
                    Name = "Aries"
                }
            };

            Member member2 = new Member()
            {
                ZodiacSign = new ZodiacSign()
                {
                    Name = "Pisces"
                }
            };

            // act
            bool result1 = ChangingAParameterToOneOfItsPropertiesExample.Is2022ZodiacLuckyPerson(member1);
            bool result2 = ChangingAParameterToOneOfItsPropertiesExample.Is2022ZodiacLuckyPerson(member2);

            // assert
            Assert.AreEqual(true, result1);
            Assert.AreEqual(false, result2);
        }
    }
}
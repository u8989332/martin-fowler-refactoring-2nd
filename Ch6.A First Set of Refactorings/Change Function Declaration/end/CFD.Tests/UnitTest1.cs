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
            int result = RenameAFunctionSimpleExample.ConvertDaysToSeconds(days);

            // assert
            Assert.AreEqual(432000, result);
        }

        [Test]
        public void Call_RenameAFunctionMigrationExample_Return_Correct_Seconds()
        {
            // arrange
            int days = 5;

            // act.
            int result1 = RenameAFunctionMigrationExample.Seconds(days);
            int result2 = RenameAFunctionMigrationExample.ConvertDaysToSeconds(days);

            // assert
            Assert.AreEqual(432000, result1);
            Assert.AreEqual(432000, result2);
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
            bool result1 = ChangingAParameterToOneOfItsPropertiesExample.Is2022ZodiacLuckyPerson(member1.ZodiacSign.Name);
            bool result2 = ChangingAParameterToOneOfItsPropertiesExample.Is2022ZodiacLuckyPerson(member2.ZodiacSign.Name);

            // assert
            Assert.AreEqual(true, result1);
            Assert.AreEqual(false, result2);
        }
    }
}
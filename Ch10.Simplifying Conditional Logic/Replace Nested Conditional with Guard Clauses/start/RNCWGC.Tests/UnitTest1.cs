using RNCWGC.Core;
using NUnit.Framework;

namespace RNCWGC.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_ASimpleExample_With_3_Cars_Return_Correct_Status()
        {
            // arrange
            Car car1 = new Car(true, false);
            Car car2 = new Car(false, true);
            Car car3 = new Car(false, false);

            // act
            CarStatus result1 = ASimpleExample.GetCarStatus(car1);
            CarStatus result2 = ASimpleExample.GetCarStatus(car2);
            CarStatus result3 = ASimpleExample.GetCarStatus(car3);

            // assert
            Assert.AreEqual(CarStatus.Bad, result1);
            Assert.AreEqual(CarStatus.Normal, result2);
            Assert.AreEqual(CarStatus.Good, result3);
        }

        [TestCase(2, 9, 8, 0)]
        [TestCase(4, 1, 7, 0)]
        [TestCase(5, 4, 1, 0)]
        [TestCase(9, 5, 7, 68021.09)]
        public void Call_ReversingTheConditions_With_4_Stones_Return_Correct_Value(int hardness, int fluorescence, int clarity, double expectResult)
        {
            // arrange
            Stone stone = new Stone(hardness, fluorescence, clarity);

            // act
            double result = ReversingTheConditions.GetStoneValue(stone);

            // assert
            Assert.AreEqual(expectResult, result, 0.01);
        }
    }
}
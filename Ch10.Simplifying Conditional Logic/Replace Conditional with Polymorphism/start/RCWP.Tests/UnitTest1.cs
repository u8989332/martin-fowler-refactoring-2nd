using System.Collections.Generic;
using RCWP.Core;
using NUnit.Framework;

namespace RCWP.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_ASimpleExample_With_6_Guns_Return_Correct_Damage_and_Size()
        {
            // arrange
            Gun gun1 = new Gun("Gun1", "Handgun", 6, false);
            Gun gun2 = new Gun("Gun2", "Shotgun", 4, false);
            Gun gun3 = new Gun("Gun3", "Shotgun", 2, false);
            Gun gun4 = new Gun("Gun4", "Rifle", 10, false);
            Gun gun5 = new Gun("Gun5", "Rifle", 8, true);
            Gun gun6 = new Gun("Gun6", "Laser", 999, false);
            List<Gun> guns = new List<Gun>()
            {
                gun1,
                gun2,
                gun3,
                gun4,
                gun5,
                gun6
            };

            // act

            var damageResult = ASimpleExample.GunDamages(guns);
            var sizeResult = ASimpleExample.GunSizes(guns);

            // assert
            Assert.AreEqual("Gun1", damageResult[0].Name);
            Assert.AreEqual(30, damageResult[0].Damage);
            Assert.AreEqual("Gun2", damageResult[1].Name);
            Assert.AreEqual(80, damageResult[1].Damage);
            Assert.AreEqual("Gun3", damageResult[2].Name);
            Assert.AreEqual(40, damageResult[2].Damage);
            Assert.AreEqual("Gun4", damageResult[3].Name);
            Assert.AreEqual(60, damageResult[3].Damage);
            Assert.AreEqual("Gun5", damageResult[4].Name);
            Assert.AreEqual(80, damageResult[4].Damage);
            Assert.AreEqual("Gun6", damageResult[5].Name);
            Assert.AreEqual(0, damageResult[5].Damage);


            Assert.AreEqual("Gun1", sizeResult[0].Name);
            Assert.AreEqual("Small", sizeResult[0].Size);
            Assert.AreEqual("Gun2", sizeResult[1].Name);
            Assert.AreEqual("Large", sizeResult[1].Size);
            Assert.AreEqual("Gun3", sizeResult[2].Name);
            Assert.AreEqual("Medium", sizeResult[2].Size);
            Assert.AreEqual("Gun4", sizeResult[3].Name);
            Assert.AreEqual("Medium", sizeResult[3].Size);
            Assert.AreEqual("Gun5", sizeResult[4].Name);
            Assert.AreEqual("Large", sizeResult[4].Size);
            Assert.AreEqual("Gun6", sizeResult[5].Name);
            Assert.AreEqual("Unknown", sizeResult[5].Size);
        }

        [Test]
        public void Call_UsingPolymorphismForVariationExample_With_Restaurant_Shareholder_Return_Rating_A()
        {
            // arrange
            Restaurant restaurant = new Restaurant(30, "Nantou City");
            List<Shareholder> shareholders = new List<Shareholder>()
            {
                new Shareholder(5, "Nantou City"),
                new Shareholder(7, "Tainan City")
            };

            // act
            string result = UsingPolymorphismForVariationExample.RatingRestaurant(restaurant, shareholders);

            // assert
            Assert.AreEqual("A", result);
        }

        [Test]
        public void Call_UsingPolymorphismForVariationExample_With_Restaurant_Shareholder_Return_Rating_B()
        {
            // arrange
            Restaurant restaurant = new Restaurant(50, "Taichung City");
            List<Shareholder> shareholders = new List<Shareholder>()
            {
                new Shareholder(1, "Taichung City")
            };

            // act
            string result = UsingPolymorphismForVariationExample.RatingRestaurant(restaurant, shareholders);

            // assert
            Assert.AreEqual("B", result);
        }
    }
}
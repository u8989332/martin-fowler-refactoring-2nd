using IPO.Core;
using NUnit.Framework;
using System.Collections.Generic;

namespace IPO.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // arrange
            StockFarm farm = new StockFarm()
            {
                Name = "HappyFarm",
                Pigs = new List<Pig>()
                {
                    new Pig() {Age = 5, Weight = 90},
                    new Pig() {Age = 7, Weight = 45},
                    new Pig() {Age = 12, Weight = 33},
                    new Pig() {Age = 6, Weight = 120},
                }
            };

            
            // act
            var result = ChangeFunctionDeclarationExample.PigsOutsideRange(farm, new WeightRange(40, 100));

            // assert
            CollectionAssert.AreEqual(
                new List<Pig>
                {
                    new Pig(){Age = 12, Weight = 33}, 
                    new Pig() { Age = 6, Weight = 120 }
                }, 
                result, 
                new PigComparer());
        }

        internal class PigComparer : Comparer<Pig>
        {
            public override int Compare(Pig? x, Pig? y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (ReferenceEquals(null, y)) return 1;
                if (ReferenceEquals(null, x)) return -1;
                if (x.Age < y.Age)
                {
                    return -1;
                }

                if (x.Age > y.Age)
                {
                    return 1;
                }

                if (x.Weight < y.Weight)
                {
                    return -1;
                }

                if (x.Weight > y.Weight)
                {
                    return 1;
                }
                return 0;
            }
        }
    }
}
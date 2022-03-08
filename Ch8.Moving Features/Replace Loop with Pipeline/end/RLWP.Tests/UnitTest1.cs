using NUnit.Framework;
using RLWP.Core;

namespace RLWP.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_ASimpleExample_Return_Correct_Students()
        {
            // act
            var result = ASimpleExample.GetHighHeightStudentsFromCsv();

            // assert
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("Jack", result[0].Name);
            Assert.AreEqual("1", result[0].Id);
            Assert.AreEqual("Billy", result[1].Name);
            Assert.AreEqual("3", result[1].Id);
            Assert.AreEqual("Jessie", result[2].Name);
            Assert.AreEqual("5", result[2].Id);
        }
    }
}
using NUnit.Framework;
using SplitLoop.Core;

namespace SplitLoop.Tests
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
            // act
            string result = ASimpleExample.GetExamResult();

            // assert
            Assert.AreEqual("Highest score: 90, total score: 277", result);
        }
    }
}
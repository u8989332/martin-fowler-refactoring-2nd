using NUnit.Framework;
using RPWO.Core;

namespace RPWO.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_SimpleExample_GetHighLevelPlayers_Return_Correct_Count()
        {
            // act
            int result = SimpleExample.GetHighLevelPlayers();

            // assert
            Assert.AreEqual(2, result);
        }
    }
}
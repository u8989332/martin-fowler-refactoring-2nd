using EncapsulateRecord.Core;
using NUnit.Framework;
using System.Collections.Generic;

namespace EncapsulateRecord.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_SimpleRecordExample_Can_Return_Correct_Result()
        {
            // arrange
            // act
            string result = SimpleRecordExample.UpdateStudentName("Tom");

            // assert
            Assert.AreEqual("The original name: John\nThe updated name: Tom", result);
        }

        [Test]
        public void Call_EncapsulatingANestedRecordExample_Can_Return_Correct_Result()
        {
            // arrange
            // act
            EncapsulatingANestedRecordExample.UpdateResearchPerformance("CS195", "John", "Publications", 90);
            int result = EncapsulatingANestedRecordExample.GetTotalPerformanceScores("CS195", "John");

            // assert
            Assert.AreEqual(215, result);
        }
    }
}
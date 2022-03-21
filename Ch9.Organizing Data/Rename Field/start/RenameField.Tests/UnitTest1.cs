using NUnit.Framework;
using RenameField.Core;

namespace RenameField.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Create_Job_Instance_Can_Correct_Set_Get_Fields()
        {
            // arrange
            Job job = new Job() { Name = "Software Engineer", Company = "HappyInc" };

            // act
            job.Name = "Senior Engineer";

            // assert
            Assert.AreEqual("Senior Engineer", job.Name);
        }
    }
}
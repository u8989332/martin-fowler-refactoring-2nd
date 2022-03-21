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
            JobRecord job = new JobRecord(new Job() { Title = "Software Engineer", Company = "HappyInc" }) ;

            // act
            job.Title = "Senior Engineer";

            // assert
            Assert.AreEqual("Senior Engineer", job.Title);
        }
    }
}
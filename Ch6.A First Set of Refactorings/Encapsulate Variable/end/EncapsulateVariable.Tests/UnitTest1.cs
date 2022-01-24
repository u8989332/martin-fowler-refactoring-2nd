using EncapsulateVariable.Core;
using NUnit.Framework;

namespace EncapsulateVariable.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Get_Set_SimpleExample_Correctly()
        {
            // arrange
            TestOrder order = new TestOrder
            {
                User = SimpleExample.DefaultUser
            };

            // act
            SimpleExample.DefaultUser = new User("Harry", "Potter");

            // assert
            Assert.AreEqual("John", order.User.FirstName);
            Assert.AreEqual("Donald", order.User.LastName);
            Assert.AreEqual("Harry", SimpleExample.DefaultUser.FirstName);
            Assert.AreEqual("Potter", SimpleExample.DefaultUser.LastName);
        }

        [Test]
        public void Get_Set_EncapsulatingTheValueExample_Correctly()
        {
            // arrange
            TestOrder order = new TestOrder
            {
                User = EncapsulatingTheValueExample.DefaultUser
            };

            // act
            EncapsulatingTheValueExample.DefaultUser = new User("Harry", "Potter");

            // assert
            Assert.AreEqual("John", order.User.FirstName);
            Assert.AreEqual("Donald", order.User.LastName);
            Assert.AreEqual("Harry", EncapsulatingTheValueExample.DefaultUser.FirstName);
            Assert.AreEqual("Potter", EncapsulatingTheValueExample.DefaultUser.LastName);
        }
    }

    public class TestOrder
    {
        public User User { get; set; }
    }
}
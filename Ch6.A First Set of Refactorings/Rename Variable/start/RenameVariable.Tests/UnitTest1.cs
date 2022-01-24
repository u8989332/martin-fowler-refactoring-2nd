using NUnit.Framework;
using RenameVariable.Core;

namespace RenameVariable.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_EncapsulatingVariableExample_Get_Set_Correctly()
        {
            // arrange & act
            string myHeight = "Today's height is " + EncapsulatingVariableExample.H;
            EncapsulatingVariableExample.H = 800;

            // assert
            Assert.AreEqual("Today's height is 999", myHeight);
            Assert.AreEqual(800, EncapsulatingVariableExample.H);
        }

        [Test]
        public void Call_RenamingAConstantExample_Constant_Correctly()
        {
            // assert
            Assert.AreEqual("Code Paradise Road", RenamingAConstantExample.Adr);
        }
    }
}
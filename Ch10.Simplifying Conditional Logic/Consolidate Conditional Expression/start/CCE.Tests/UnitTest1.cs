using CCE.Core;
using NUnit.Framework;

namespace CCE.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_4_Product_Discount_Return_Correct_Discount()
        {
            // arrange
            Product product1 = new Product(ProductType.Normal, 6666, false);
            Product product2 = new Product(ProductType.NonDiscount, 214, false);
            Product product3 = new Product(ProductType.Normal, 426, true);
            Product product4 = new Product(ProductType.Normal, 693, false);

            // act
            double result1 = UsingOrsExample.Discount(product1);
            double result2 = UsingOrsExample.Discount(product2);
            double result3 = UsingOrsExample.Discount(product3);
            double result4 = UsingOrsExample.Discount(product4);

            // assert
            Assert.AreEqual(0, result1, 0.01);
            Assert.AreEqual(0, result2, 0.01);
            Assert.AreEqual(0, result3, 0.01);
            Assert.AreEqual(34.65, result4, 0.01);
        }

        [Test]
        public void Call_3_Student_SummerCampPrice_Return_Correct_Price()
        {
            // arrange
            Student student1 = new Student(3, 75);
            Student student2 = new Student(1, 90);
            Student student3 = new Student(4, 83);
       
            // act
            double result1 = UsingAndsExample.SummerCampPrice(student1);
            double result2 = UsingAndsExample.SummerCampPrice(student2);
            double result3 = UsingAndsExample.SummerCampPrice(student3);

            // assert
            Assert.AreEqual(1000, result1);
            Assert.AreEqual(1000, result2);
            Assert.AreEqual(500, result3);
        }
    }
}
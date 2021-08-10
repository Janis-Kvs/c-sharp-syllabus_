using System.Net.WebSockets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void PrintProduct_NamePhonePriceAtStart134Amount34Given_StringRepresentationExpected()
        {
            //Arrange
            Product product = new Product("Phone", 134, 34);
            //Act
            var actual = product.PrintProduct();
            var expected = "Phone, price: 134 EUR, amount: 34 units";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChangeQuantity_Amount34ChangeTo54_Amount54Expected()
        {
            //Arrange
            Product product = new Product("Phone", 134, 34);
            //Act
            product.ChangeQuantity(54);
            var actual = product.Amount;
            var expected = 54;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChangePrice_Price134ChangeTo154_Price154Expected()
        {
            //Arrange
            Product product = new Product("Phone", 134, 34);
            //Act
            product.ChangePrice(154);
            var actual = product.Price;
            var expected = 154;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

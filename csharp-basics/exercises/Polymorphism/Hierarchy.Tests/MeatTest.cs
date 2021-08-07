using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class VegetableTest
    {
        
        [TestMethod]
        public void ToString_3Given_VegetableExpected()
        {
            //Arrange
            Vegetable veg = new Vegetable(55);
            //Act
            var actual = veg.ToString();
            var expected = "Vegetable";
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

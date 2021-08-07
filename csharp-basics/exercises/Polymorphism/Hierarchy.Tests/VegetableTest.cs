using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class MeatTest
    {
        
        [TestMethod]
        public void ToString_3Given_VegetableExpected()
        {
            //Arrange
            Meat meat = new Meat(55);
            //Act
            var actual = meat.ToString();
            var expected = "Meat";
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

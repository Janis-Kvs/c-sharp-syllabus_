using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class ZebraTest
    {
        [TestMethod]
        public void MakeSound_ValidZebra_BarkBarkExpected()
        {
            //Arrange
            Zebra zebra = new Zebra("Zeb", "Zebra",77, "Field");
            //Act
            var actual = zebra.MakeSound();
            var expected = "Bark-Bark";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3Given_3Expected()
        {
            //Arrange
            Zebra zebra = new Zebra("Zeb", "Zebra", 77, "Field");
            Food food = new Vegetable(3);
            //Act
            var actual = zebra.Eat(food);
            var expected = 3;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_MouseEatOnlyVegetables_ExceptionExpected()
        {
            //Arrange
            Zebra zebra = new Zebra("Zeb", "Zebra", 77, "Field");
            Food food = new Meat(3);
            //Assert
            Assert.ThrowsException<ArgumentException>(() => zebra.Eat(food));
        }

        [TestMethod]
        public void ToString_ZebZebra77Field_ZebraZeb77Field0Expected()
        {
            //Arrange
            Zebra zebra = new Zebra("Zeb", "Zebra", 77, "Field");
            //Act
            var actual = zebra.ToString();
            var expected = "Zebra [Zeb, 77, Field, 0]";
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

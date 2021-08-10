using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class MouseTest
    {
        [TestMethod]
        public void MakeSound_ValidMouse_PiiiPiiiExpected()
        {
            //Arrange
            Mouse mouse = new Mouse("Pele", "Mouse",1, "Barn");
            //Act
            var actual = mouse.MakeSound();
            var expected = "Piii-Piii";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3Given_3Expected()
        {
            //Arrange
            Mouse mouse = new Mouse("Pele", "Mouse", 1, "Barn");
            Food food = new Vegetable(3);
            //Act
            var actual = mouse.Eat(food);
            var expected = 3;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_MouseEatOnlyVegetables_ExceptionExpected()
        {
            //Arrange
            Mouse mouse = new Mouse("Pele", "Mouse", 1, "Barn");
            Food food = new Meat(3);
            //Assert
            Assert.ThrowsException<ArgumentException>(() => mouse.Eat(food));
        }

        [TestMethod]
        public void ToString_PeleMouse1Barn_MousePele1Barn0Expected()
        {
            //Arrange
            Mouse mouse = new Mouse("Pele", "Mouse", 1, "Barn");
            //Act
            var actual = mouse.ToString();
            var expected = "Mouse [Pele, 1, Barn, 0]";
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

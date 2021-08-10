using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class CatTest
    {
        [TestMethod]
        public void MakeSound_ValidCat_MeowwwwExpected()
        {
            //Arrange
            Cat cat = new Cat("Minka", "Cat",11, "Home", "Persian");
            //Act
            var actual = cat.MakeSound();
            var expected = "Meowwww";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3VegetableGiven_3Expected()
        {
            //Arrange
            Cat cat = new Cat("Minka", "Cat", 11, "Home", "Persian");
            Food food = new Vegetable(3);
            //Act
            var actual = cat.Eat(food);
            var expected = 3;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3MeatGiven_3Expected()
        {
            //Arrange
            Cat cat = new Cat("Minka", "Cat", 11, "Home", "Persian");
            Food food = new Meat(3);
            //Act
            var actual = cat.Eat(food);
            var expected = 3;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_MinkaCat11HomePersian_CatMinkaPersian11Home0Expected()
        {
            //Arrange
            Cat cat = new Cat("Minka", "Cat", 11, "Home", "Persian");
            //Act
            var actual = cat.ToString();
            var expected = "Cat [Minka, Persian, 11, Home, 0]";
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

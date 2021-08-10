using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class TigerTest
    {
        [TestMethod]
        public void MakeSound_ValidTiger_ROAARExpected()
        {
            //Arrange
            Tiger tiger = new Tiger("LielsKakis", "Tiger",113, "Savannah");
            //Act
            var actual = tiger.MakeSound();
            var expected = "ROAAR!!!";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3MeatGiven_3Expected()
        {
            //Arrange
            Tiger tiger = new Tiger("LielsKakis", "Tiger", 113, "Savannah");
            Food food = new Meat(3);
            //Act
            var actual = tiger.Eat(food);
            var expected = 3;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_TigerEatOnlyMeat_ExceptionExpected()
        {
            //Arrange
            Tiger tiger = new Tiger("LielsKakis", "Tiger", 113, "Savannah");
            Food food = new Vegetable(3);
            //Assert
            Assert.ThrowsException<ArgumentException>(() => tiger.Eat(food));
        }

        [TestMethod]
        public void ToString_LielsKakisTiger113Savannah_TigerLielsKakis113Savannah0Expected()
        {
            //Arrange
            Tiger tiger = new Tiger("LielsKakis", "Tiger", 113, "Savannah");
            //Act
            var actual = tiger.ToString();
            var expected = "Tiger [LielsKakis, 113, Savannah, 0]";
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

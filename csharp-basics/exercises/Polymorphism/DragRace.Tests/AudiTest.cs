using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Tests
{
    [TestClass]
    public class AudiTest
    {
        [TestMethod]
        public void SpeedUp_SpeedUpBy1_1Expected()
        {
            //Arrange
            Audi aCar = new Audi();
            //Act
            var actual = aCar.SpeedUp();
            var expected = 1;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SlowDown_SlowDownBy1_1Expected()
        {
            //Arrange
            Audi aCar = new Audi();
            aCar.SpeedUp();
            aCar.SpeedUp();
            //Act
            var actual = aCar.SlowDown();
            var expected = 1;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShowCurrentSpeed_1Given_1Expected()
        {
            //Arrange
            Audi aCar = new Audi();
            aCar.SpeedUp();
            //Act
            var actual = aCar.ShowCurrentSpeed();
            var expected = 1;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StartEngine_RrrrrrrExpected()
        {
            //Arrange
            Audi aCar = new Audi();
            //Act
            var actual = aCar.StartEngine();
            var expected = "Rrrrrrr.....";
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

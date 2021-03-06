using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Tests
{
    [TestClass]
    public class OpelTest
    {
        [TestMethod]
        public void SpeedUp_SpeedUpBy1_1Expected()
        {
            //Arrange
            Opel aCar = new Opel();
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
            Opel aCar = new Opel();
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
            Opel aCar = new Opel();
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
            Opel aCar = new Opel();
            //Act
            var actual = aCar.StartEngine();
            var expected = "Rrrrrrr.....";
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

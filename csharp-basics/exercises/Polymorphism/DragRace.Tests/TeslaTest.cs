using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Tests
{
    [TestClass]
    public class TeslaTest
    {
        [TestMethod]
        public void SpeedUp_SpeedUpBy1_1Expected()
        {
            //Arrange
            Tesla aCar = new Tesla();
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
            Tesla aCar = new Tesla();
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
            Tesla aCar = new Tesla();
            aCar.SpeedUp();
            //Act
            var actual = aCar.ShowCurrentSpeed();
            var expected = 1;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StartEngine_silenceExpected()
        {
            //Arrange
            Tesla aCar = new Tesla();
            //Act
            var actual = aCar.StartEngine();
            var expected = "----silence----";
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

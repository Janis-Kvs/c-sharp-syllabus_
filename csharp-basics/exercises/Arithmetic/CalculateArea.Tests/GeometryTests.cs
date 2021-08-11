using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateArea.Tests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void AreaOfCircle_Radius5_78Point54Expected()
        {
            //Act
            var actual = Geometry.areaOfCircle(5);
            //Assert
            Assert.AreEqual(78.54, actual);
        }

        [TestMethod]
        public void AreaOfCircle_NegativeValuesGiven_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfCircle(-5));
        }

        [TestMethod]
        public void AreaOfRectangle_Width5Length10_50Expected()
        {
            //Act
            var actual = Geometry.areaOfRectangle(10,5);
            //Assert
            Assert.AreEqual(50, actual);
        }

        [TestMethod]
        public void AreaOfRectangle_NegativeValuesGiven_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfRectangle(-10,5));
        }

        [TestMethod]
        public void AreaOfTriangle_Ground10Height5_25Expected()
        {
            //Act
            var actual = Geometry.areaOfTriangle(10, 5);
            //Assert
            Assert.AreEqual(25, actual);
        }

        [TestMethod]
        public void AreaOfTriangle_NegativeValuesGiven_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfTriangle(-10, 5));
        }
    }
}

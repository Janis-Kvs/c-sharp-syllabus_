using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateArea.Tests
{
    [TestClass]
    public class GeometryTests
    {

        [TestMethod]
        public void areaOfCircle_Radius5_78_5Expected()
        {
            //Act
            var actual = Geometry.areaOfCircle(5);
            //Assert
            Assert.AreEqual(78.54, actual);
        }

        [TestMethod]
        public void areaOfCircle_NegativeValuesGiven_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfCircle(-5));
        }

        [TestMethod]
        public void areaOfRectangle_Width5Length10_50Expected()
        {
            //Act
            var actual = Geometry.areaOfRectangle(10,5);
            //Assert
            Assert.AreEqual(50, actual);
        }

        [TestMethod]
        public void areaOfRectangle_NegativeValuesGiven_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfRectangle(-10,5));
        }

        [TestMethod]
        public void areaOfTriangle_Ground10Height5_25Expected()
        {
            //Act
            var actual = Geometry.areaOfTriangle(10, 5);
            //Assert
            Assert.AreEqual(25, actual);
        }

        [TestMethod]
        public void areaOfTriangle_NegativeValuesGiven_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfTriangle(-10, 5));
        }
    }
}

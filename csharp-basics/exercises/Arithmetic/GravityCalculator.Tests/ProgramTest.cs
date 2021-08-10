using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GravityCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPosition_FallingTime10Velocity2Position32_438_5Expected()
        {
            //Arrange
            var fallingTime = 10;
            var initialVelocity = 2;
            var initialPosition = 32;
            //Act
            var actual = Program.GetPosition(fallingTime, initialVelocity, initialPosition);
            //Assert
            Assert.AreEqual(-438.5, actual);
        }
    }
}

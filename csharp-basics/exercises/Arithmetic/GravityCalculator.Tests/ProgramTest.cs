using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GravityCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPosition_FallingTime10Velocity2Position32_438_5Expected()
        {
            //Act
           var actual = Program.GetPosition(10,2,32);
            //Assert
            Assert.AreEqual(-438.5, actual);
        }
    }
}

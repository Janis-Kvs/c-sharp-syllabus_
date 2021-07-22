using NUnit.Framework;
using Exercise5;

namespace DateTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        private Date _target;

        [Test]
        public void DisplayDate_day21month7year2021()
        {
            //Arrange
            _target = new Date(21, 7, 2021);
            //Act
            var actualResult = _target.DisplayDate();
            string expectedResult = "7/21/2021";
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
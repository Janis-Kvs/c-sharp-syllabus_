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

        [Test]
        public void DisplayDate_day21month7year2021()
        {
            //Arrange
             Date _target = new Date(21, 7, 2021);
            //Act
            var actual = _target.DisplayDate();
            string expected = "7/21/2021";
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
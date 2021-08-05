using NUnit.Framework;

namespace CheckOddEven.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsEven_2_EvenExpected()
        {
            //Arrange 
            int number1 = 2;
            //Act
            var expected = "Even Number";
            var actual = Program.IsEven(number1);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsEven_2_OddExpected()
        {
            //Arrange 
            int number1 = 3;
            //Act
            var expected = "Odd Number";
            var actual = Program.IsEven(number1);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
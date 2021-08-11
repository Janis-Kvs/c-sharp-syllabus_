using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordCount.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void CountLines_3LineText_3Expected()
        {
            //Arrange
            string text = "My name is Janis \n and I live in Riga \n for 10'th year.";
            //Act
            string expected = "Lines = 3";
            var actual = Program.CountLines(text);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountWords_13WordText_13Expected()
        {
            //Arrange
            string text = "My name is Janis \n and I live in Riga \n for 10'th year.";
            //Act
            string expected = "Words = 13";
            var actual = Program.CountWords(text);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountCharacters_53CharacterText_53Expected()
        {
            //Arrange
            string text = "My name is Janis \n and I live in Riga \n for 10'th year.";
            //Act
            string expected = "Characters = 53";
            var actual = Program.CountCharacters(text);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

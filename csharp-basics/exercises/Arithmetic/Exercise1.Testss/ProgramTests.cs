using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Testss
{
    [TestClass]
    public class ProgramTests
    {
    
        [DataTestMethod]
        [DataRow(15, 3, true)]
        [DataRow(3, 4, false)]
        [DataRow(15, 4, true)]
        public void Is15Test(int number1, int number2, bool Is15)
        {
            //Act
            var actual = Program.Is15(number1, number2);
            //Assert
            Assert.AreEqual(Is15, actual);
        }

        [DataTestMethod]
        [DataRow(5, 10, true)]
        [DataRow(5, 5, false)]
        public void IsSum15Test(int number1, int number2, bool IsSum15)
        {
            //Act
            var actual = Program.IsSum15(number1, number2);
            //Assert
            Assert.AreEqual(IsSum15, actual);
        }

        [DataTestMethod]
        [DataRow(15, 30, true)]
        [DataRow(5, 15, false)]
        public void IsDifference15Test(int number1, int number2, bool IsDifference15)
        {
            //Act
            var actual = Program.IsDifference15(number1, number2);
            //Assert
            Assert.AreEqual(IsDifference15, actual);
        }

        [DataTestMethod]
        [DataRow(true, false, false, true)]
        [DataRow(false, false, false, false)]
        [DataRow(false, true, false, true)]
        public void CheckTest(bool boolean1, bool boolean2, bool boolean3, bool boolean4)
        {
            //Act
            var actual = Program.Check(boolean1, boolean2, boolean3);
            //Assert
            Assert.AreEqual(boolean4, actual);
        }
    }
}

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
        public void Is15Test(int n1, int n2, bool b)
        {
            //Act
            var actual = Program.Is15(n1, n2);
            //Assert
            Assert.AreEqual(b, actual);
        }

        [DataTestMethod]
        [DataRow(5, 10, true)]
        [DataRow(5, 5, false)]
        public void IsSum15Test(int n1, int n2, bool b)
        {
            //Act
            var actual = Program.IsSum15(n1, n2);
            //Assert
            Assert.AreEqual(b, actual);
        }

        [DataTestMethod]
        [DataRow(15, 30, true)]
        [DataRow(5, 15, false)]
        public void IsDifference15Test(int n1, int n2, bool b)
        {
            //Act
            var actual = Program.IsDifference15(n1, n2);
            //Assert
            Assert.AreEqual(b, actual);
        }

        [DataTestMethod]
        [DataRow(true, false, false, true)]
        [DataRow(false, false, false, false)]
        [DataRow(false, true, false, true)]
        public void CheckTest(bool b1, bool b2, bool b3, bool b4)
        {
            //Act
            var actual = Program.Check(b1, b2, b3);
            //Assert
            Assert.AreEqual(b4, actual);
        }
    }
}

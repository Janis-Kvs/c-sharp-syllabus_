using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CozaLozaWoza.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [DataTestMethod]
        [DataRow(105, "CozaLozaWoza ")]
        [DataRow(15, "CozaLoza ")]
        [DataRow(35, "LozaWoza ")]
        [DataRow(21, "CozaWoza ")]
        [DataRow(10, "Loza ")]
        [DataRow(9, "Coza ")]
        [DataRow(14, "Woza ")]
        public void GetNameTest(int a,  string b)
        {
            //Act
            var actual = Program.GetName(a);
            //Assert
            Assert.AreEqual(b, actual);
        }
    }
}

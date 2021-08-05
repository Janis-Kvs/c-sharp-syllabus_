using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise8.Tests
{
    [TestClass]
    public class ProgramTest
    {
        [DataTestMethod]
        [DataRow(9, 61, "Error: employee has worked more than 60 hours in a week.")]
        [DataRow(7, 45, "Error: employee base pay is less than $8.00 an hour")]
        [DataRow(9, 35, "The total pay is: 315")]
        [DataRow(9, 55, "The total pay is: 562,5")]
        public void TotalPayTests(int n1, int n2, string b)
        {
            //Act
            var actual = Program.TotalPay(n1,n2);
            //Assert
            Assert.AreEqual(b, actual);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Account.Tests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Withdrawal_255_999745Expected()
        {
            //Arrange
            Account account = new Account("Janis Kazjonovs", 1000000);
            //Act
            var actual = account.Withdrawal(255);
            var expected = 999745;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Withdrawal_WithdrawalAmountLargerThanBalance_ExceptionExpected()
        {
            //Arrange
            Account account = new Account("Janis Kazjonovs", 100);
            //Assert
            Assert.ThrowsException<ArgumentException>(()=> account.Withdrawal(255));
        }

        [TestMethod]
        public void Deposit_100_1100Expected()
        {
            //Arrange
            Account account = new Account("Janis Kazjonovs", 1000);
            //Act
            var actual = account.Deposit(100);
            var expected = 1100;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Balance_100_100Expected()
        {
            //Arrange
            Account account = new Account("Janis Kazjonovs", 100);
            //Act
            var actual = account.Balance();
            var expected = 100;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_100_100Expected()
        {
            //Arrange
            Account account = new Account("Janis Kazjonovs", 100);
            //Act
            var actual = account.ToString();
            var expected = "Janis Kazjonovs: $100.00";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_Negative100_Negative100Expected()
        {
            //Arrange
            Account account = new Account("Janis Kazjonovs", -100);
            //Act
            var actual = account.ToString();
            var expected = "Janis Kazjonovs: -$100.00";
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

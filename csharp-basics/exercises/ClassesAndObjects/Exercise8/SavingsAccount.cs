using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise8
{
    class SavingsAccount
    {
        private int _rate;
        private decimal _balance;
        private decimal _totalDeposited;
        private decimal _totalWithdrawn;
        private decimal _totalEarned;

        public SavingsAccount(int startBalance)
        {
            _balance = startBalance;
            _totalDeposited = 0;
            _totalWithdrawn = 0;
            _totalEarned = 0;
        }

        public int Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        public decimal TotalEarned
        {
            get { return _totalEarned; }
        }

        public decimal TotalWithdrawn
        {
            get { return _totalWithdrawn; }
        }
        public decimal TotalDeposited
        {
            get { return _totalDeposited; }
        }
        public decimal Balance
        {
            get { return _balance; }
        }


        public void WithdrawMoney(int withdrawAmount)
        {
            _balance -= withdrawAmount;
            _totalWithdrawn += withdrawAmount;

        }

        public void AddDeposit(int depositAmount)
        {
            _balance += depositAmount;
            _totalDeposited += depositAmount;
        }

        public void AddMonthlyInterest()
        {
            decimal interestRate = _balance * _rate / 12;
            _balance += interestRate;
            _totalEarned += interestRate;
        }
    }
}

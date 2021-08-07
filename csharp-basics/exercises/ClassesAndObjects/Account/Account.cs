using System;
using System.Globalization;
using System.Threading;

namespace Account
{
    public class Account
    {
        private string _name;
        private double _balance;
        public Account(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }
        public double Withdrawal(double amount)
        {
            if (amount > _balance)
            {
                throw new ArgumentException("Withdrawal amount is larger than available balance");
            }
            return _balance -= amount;
        }
        public double Deposit(double amount)
        {
            return _balance += amount;
        }
        public double Balance()
        {
            return _balance;
        }
        public override string ToString()
        {
            CultureInfo newCulture = new CultureInfo("en-US");
            newCulture.NumberFormat.CurrencyNegativePattern = 1;
            Thread.CurrentThread.CurrentCulture = newCulture;
            return $"{_name}: {_balance.ToString("C2")}";
        }
    }
}

using System.Globalization;
using System.Threading;

namespace Account
{
    class Account
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

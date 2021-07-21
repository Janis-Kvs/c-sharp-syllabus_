using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        private string _name;
        private decimal _balance;

        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            CultureInfo newCulture = new CultureInfo("en-US");
            newCulture.NumberFormat.CurrencyNegativePattern = 1;
            Thread.CurrentThread.CurrentCulture = newCulture;
            string result = $"{_name}, {_balance.ToString("C2")}";
            return result;
        }
    }
}

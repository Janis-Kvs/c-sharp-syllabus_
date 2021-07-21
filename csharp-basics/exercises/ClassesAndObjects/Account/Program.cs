using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Exercise: Your first account");
            YourFirstAccount();
            Console.WriteLine();

            Console.WriteLine("Exercise: Your first money transfer");
            YourFirstMoneyTransfer();
            Console.WriteLine();

            Console.WriteLine("Exercise: Money transfers");
            Account aAccount = new Account("A account", 100);
            Account bAccount = new Account("B account", 0);
            Account cAccount = new Account("C Account", 0);

            Console.WriteLine("Initial state");
            Console.WriteLine(aAccount.ToString());
            Console.WriteLine(bAccount.ToString());
            Console.WriteLine(cAccount.ToString());

            Transfer(aAccount, bAccount, 50.0);
            Transfer(bAccount, cAccount, 25.0);

            Console.WriteLine("Final state");
            Console.WriteLine(aAccount.ToString());
            Console.WriteLine(bAccount.ToString());
            Console.WriteLine(cAccount.ToString());

            Console.ReadKey();
        }

        public static void YourFirstAccount()
        {
            Account testAccount = new Account("First account name", 100.00);
            testAccount.Deposit(20);
            Console.WriteLine(testAccount.ToString());
        }

        public static void YourFirstMoneyTransfer()
        {
            Account mattsAccount = new Account("Matt's account", 1000.00);
            Account myAccount = new Account("My account", 0.00);
            mattsAccount.Withdrawal(100);
            myAccount.Deposit(100);
            Console.WriteLine(mattsAccount.ToString());
            Console.WriteLine(myAccount.ToString());
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }
    }
}

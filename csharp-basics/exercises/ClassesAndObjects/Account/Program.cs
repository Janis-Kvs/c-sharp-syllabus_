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
            var aAccount = new Account("A account", 100.00);
            var bAccount = new Account("B account",0);
            var cAccount = new Account("C Account", 0);
            Console.WriteLine("Initial state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);
            aAccount.Name = "GGGG";
            Transfer(aAccount,bAccount, 50.0);
            Transfer(bAccount,cAccount, 25.0);
            
            Console.WriteLine("Final state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);

            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.deposit(from.withdrawal(howMuch));
        }
    }
}

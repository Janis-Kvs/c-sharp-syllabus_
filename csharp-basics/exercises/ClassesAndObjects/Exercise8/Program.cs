using System;
using System.Globalization;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in the account?: ");
            SavingsAccount account = new SavingsAccount(int.Parse(Console.ReadLine()));
            Console.Write("Enter the annual interest rate: ");
            account.Rate = int.Parse(Console.ReadLine());
            Console.Write("How long has the account been opened?: ");
            int months = int.Parse(Console.ReadLine());

            for (int i = 0; i < months; i++)
            {
                Console.Write($"Enter amount deposited for month {i + 1}: ");
                account.AddDeposit(int.Parse(Console.ReadLine()));
                Console.Write($"Enter amount withdrawn for month {i + 1}: ");
                account.WithdrawMoney(int.Parse(Console.ReadLine()));
                account.AddMonthlyInterest();
            }

            Console.WriteLine($"Total deposited: {account.TotalDeposited.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
            Console.WriteLine($"Total withdrawn: {account.TotalWithdrawn.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
            Console.WriteLine($"Total earned: {account.TotalEarned.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
            Console.WriteLine($"Ending balance: {account.Balance.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
        }
    }
}

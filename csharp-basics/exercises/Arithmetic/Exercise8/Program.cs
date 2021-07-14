using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            TotalPay(7.5, 35);
            TotalPay(8.2, 47);
            TotalPay(10, 73);

        }

        static void TotalPay(double basePay, int hoursWorked)
        {
            if (hoursWorked > 60)
            {
                Console.WriteLine("Error: employee has worked more than 60 hours in a week.");
                return;
            }

            if (basePay < 8)
            {
                Console.WriteLine("Error: employee base pay is less than $8.00 an hour");
                return;
            }

            if (hoursWorked <= 40)
            {
                double totalPay = basePay * hoursWorked;
                Console.WriteLine($"The total pay is: {totalPay}");
            } else
            {
                double totalPay = 40 * basePay + (hoursWorked - 40) *1.5 *basePay;
                Console.WriteLine($"The total pay is: {totalPay}");
            }

        }
        
    }
}

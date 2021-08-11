using System;

namespace Exercise8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TotalPay(7.5, 35));
            Console.WriteLine(TotalPay(8.2, 47));
            Console.WriteLine(TotalPay(10, 73));

        }

        public static string TotalPay(double basePay, int hoursWorked)
        {
            if (hoursWorked > 60)
            {
                return "Error: employee has worked more than 60 hours in a week.";
            }
            else if (basePay < 8)
            {
                return "Error: employee base pay is less than $8.00 an hour";
            }
            else if (hoursWorked <= 40)
            {
                double totalPay = basePay * hoursWorked;
                return $"The total pay is: {totalPay}";
            } 
            else
            {
                double totalPay = 40 * basePay + (hoursWorked - 40) *1.5 *basePay;
                return $"The total pay is: {totalPay}";
            }

        }
        
    }
}

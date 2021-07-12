using System;

namespace FormatCurrency_12
{
    /**
     * Currency Formatting
     *
     * The business has informed you that prices must have 2 decimal places
     * They must also start with the currency symbol
     * Write a function that transforms numbers into the format £0.00
     */

    class Program
    {
        static void Main(string[] args)
        {
            var product = "learning C sharp";
            var price = 19.99;
            var salesTax = CalculateSalesTax(price);

            Console.WriteLine("Product: " + product);
            Console.WriteLine("Price: " + FormatCurrency(price));
            Console.WriteLine("Sales tax: " + FormatCurrency(salesTax));
            Console.WriteLine("Total: " + FormatCurrency(price + salesTax));
            Console.ReadKey();
        }

        //change FormatCurrency method accordingly.
        static string FormatCurrency(double price)
        {
            return string.Empty;
        }

        static double CalculateSalesTax(double price)
        {
            return price * 0.2;
        }
    }
}

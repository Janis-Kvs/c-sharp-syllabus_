using System;

namespace ConvertCurrency_14
{
    class Program
    {

        /**
         * Currency Formatting
         *
         * The business is now breaking into the Brazilian market
         * Write a new function for converting to the Brazilian real
         * They have also decided that they should add a 1% fee to all foreign transactions
         * Find a way to add 1% to all currency conversions (think about the DRY principle)
         */

        static void Main(string[] args)
        {

            var product = "learning C sharp";
            var price = 12.5;
            var priceInUSD = ConvertToUSD(price);
            var priceInBRL = ConvertToBRL(price);

            Console.WriteLine("Product: " + product);
            Console.WriteLine("Price in USD: " + priceInUSD);
            Console.WriteLine("Price in BRL: " + priceInBRL);
            Console.ReadKey();
        }

        //change this method accordingly
        static double ConvertToUSD(double price)
        {
            return price;
        }

        //change this method accordingly
        static double ConvertToBRL(double price)
        {
            return price;
        }
    }
}

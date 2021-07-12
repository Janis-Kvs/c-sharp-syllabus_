using System;

namespace ConvertCurrency_13
{
    class Program
    {
        /**
         * Currency Formatting
         *
         * The business is breaking out into a new market and need to convert prices to USD
         * Write a function that converts a price to USD (exchange rate is 1.4 $ to £)
         */
        static void Main(string[] args)
        {
            var product = "learning C sharp";
            var price = 19.99;
            var priceInUSD = ConvertToUSD(price);

            Console.WriteLine("Product: " + product);
            Console.WriteLine("Price in USD: " + priceInUSD);
            Console.ReadKey();
        }


        //change this method accordingly
        static double ConvertToUSD(double price)
        {
            return price;
        }
    }
}

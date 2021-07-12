using System;

namespace Tax_11
{

    /**
     * Sales Tax
     *
     * A business requires a program that calculates how much sales tax to charge
     * Sales tax is 20% of the price of the product
     */
    class Program
    {
        static void Main(string[] args)
        {
            string product = "learning C sharp";
            var price = 19.99;
            var salesTax = CalculateSalesTax(price);

            Console.WriteLine("Product: " + product);
            Console.WriteLine("Price: £" + price);
            Console.WriteLine("Sales tax: £" + salesTax);
            Console.WriteLine("Total: £" + (price + salesTax));
            Console.ReadKey();

        }

        //change only this method accordingly.
        static double CalculateSalesTax(double price)
        {
            return price;
        }
    }
}

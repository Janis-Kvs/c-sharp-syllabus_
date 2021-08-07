using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> _products = new List<Product>();
            _products.Add(new Product("Logitech mouse", 70.00,14));
            _products.Add(new Product("iPhone 5s",999.99, 3));
            _products.Add(new Product("Epson EB-U05",440.46, 1));

            foreach (Product product in _products)
            {
                Console.WriteLine(product.PrintProduct());

                Console.WriteLine("What is the new amount of product?");
                string newAmount = Console.ReadLine();
                if (newAmount != string.Empty)
                {
                    product.ChangeQuantity(int.Parse(newAmount));
                }

                Console.WriteLine("What is the new price of product?");
                string newPrice = Console.ReadLine();
                if (newPrice != string.Empty)
                {
                    product.ChangePrice(int.Parse(newPrice));
                }

                product.PrintProduct();
                Console.WriteLine();
            }
        }
    }
}

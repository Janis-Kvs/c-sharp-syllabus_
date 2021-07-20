using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Product
    {
        private string _name;
        private double _priceAtStart;
        private int _amountAtStart;
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _priceAtStart = priceAtStart;
            _amountAtStart = amountAtStart;

        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, price: {_priceAtStart} EUR, amount: {_amountAtStart} units");
        }
        public void ChangeQuantity(int quantity)
        {
            _amountAtStart = quantity;
        }
        public void ChangePrice(double price)
        {
            _priceAtStart = price;
        }
    }
}

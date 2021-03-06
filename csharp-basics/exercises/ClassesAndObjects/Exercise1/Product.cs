using System;

namespace Exercise1
{
    public class Product
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
        public double Amount
        {
            get { return _amountAtStart; }   // get method
        }

        public double Price
        {
            get { return _priceAtStart; }   // get method
        }

        public string PrintProduct()
        {
            return $"{_name}, price: {_priceAtStart} EUR, amount: {_amountAtStart} units";
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Food
    {
        protected int _quantity;

        protected Food(int quantity)
        {
            _quantity = quantity;
        }
        public int Quantity
        {
            get => _quantity;
            protected set => _quantity = value;
        }
    }
}

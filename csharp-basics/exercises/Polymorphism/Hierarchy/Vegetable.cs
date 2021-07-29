using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Vegetable : Food
    {
        public Vegetable(int quantity) : base(quantity)
        {
        }

        public override string ToString()
        {
            return "Vegetable";
        }
    }
}

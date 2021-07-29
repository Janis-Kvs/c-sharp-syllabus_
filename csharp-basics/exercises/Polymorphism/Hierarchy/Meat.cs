using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Meat : Food
    {
        public Meat(int quantity) : base(quantity)
        {
        }

        public override string ToString()
        {
            return "Meat";
        }
    }
}

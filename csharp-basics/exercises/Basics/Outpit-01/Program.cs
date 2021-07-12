using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_01
{
    class Program
    {
        //finish Main method so it shows the result from function.

        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        static int GetNumber()
        {
            return new Random().Next() * 10;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            string element0 = colors[0];
            Console.WriteLine("First element: " + element0);
            string element3 = colors[2];
            Console.WriteLine("Third element: " + element3);
            Console.ReadKey();
        }
    }
}

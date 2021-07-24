using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>() {"blue", "green", "purple"};
            colors.Add("Red");
            colors.Add("black");
            colors.Add("White");
            colors.Add("gray");
            colors.Add("blue");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine(string.Join(",", firstList));

            var secondList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine(string.Join(",", secondList));

            //Option one - using Enumerable.Concat() method
            var concat = firstList.Concat(secondList);
            Console.WriteLine(string.Join(",", concat));

            //Option two - Using AddRange() method
            firstList.AddRange(secondList);
            Console.WriteLine(string.Join(",", firstList));

            //Option three - Using List<T>.ForEach(Action<T>) method
            secondList.ForEach(item => firstList.Add(item));
            Console.WriteLine(string.Join(",", firstList));

            Console.ReadKey();
        }
    }
}

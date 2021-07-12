using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = RandomIntegers(20);
            Console.Write("There are few integers given: ");
            Console.WriteLine("[{0}]", string.Join(", ", integers));
            Console.WriteLine("Which number index would you like to find?");

            int searchFor = Convert.ToInt16(Console.ReadLine());
            

            int i;
            var foundIt = false;

            for (i = 0; i < integers.Length; i++) {
                //todo - search for integer - break when you have found what you searched for
            }

            if (foundIt) {
                Console.WriteLine("Found " + searchFor + " at index " + i);
            } else {
                Console.WriteLine(searchFor + " is not in the array");
            }
        }

        static int[] RandomIntegers(int n)
        {
            var list = new List<int>();
            var random = new Random();


            for (var i = 0; i < n; i++)
            {
                var randomNumber = random.Next(0, 99);
                list.Add(randomNumber);
            }

            return list.ToArray();
        }
    }
}

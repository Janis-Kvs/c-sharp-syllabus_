using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            double sum = 0;

            Console.WriteLine("Please enter a number: ");
            string number = Console.ReadLine();
            Console.WriteLine("How many tries do you want to be made?: ");
            int times = int.Parse(Console.ReadLine());

            var intList = number.Select(digit => int.Parse(digit.ToString()));
            for (int i = 0; i < times; i++)
            {
                foreach (int element in intList)
                {
                    sum += Math.Pow(element, 2);
                }

                if (sum == 1)
                {
                    Console.WriteLine("happy");
                    break;
                }

                var newNumber = sum.ToString();
                intList = newNumber.Select(digit => int.Parse(digit.ToString()));
                sum = 0;
            }
        }
    }
}

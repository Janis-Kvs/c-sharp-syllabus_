using System;

namespace Exercise2
{
    class Program
    {       
        //TODO: Write a C# program to sum values of an array.
        private static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());

            for (int i = minNumber; i <= maxNumber; i++)
            {
                sum += myArray[i - 1];
            }

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
            }
        }
}

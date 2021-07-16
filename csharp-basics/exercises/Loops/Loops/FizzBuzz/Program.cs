using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the max value? ");
            int.TryParse(Console.ReadLine(), out int number);

            for (int i = 1; i <= number; i++)
            {
                if (i % 15 == 0)
                    Console.Write("FizzBuzz ");
                else if (i % 5 == 0)
                    Console.Write("Buzz ");
                else if (i % 3 == 0)
                    Console.Write("Fizz ");
                else Console.Write(i + " ");
                if (i % 20 == 0)
                    Console.WriteLine();
            }
        }
    }
}

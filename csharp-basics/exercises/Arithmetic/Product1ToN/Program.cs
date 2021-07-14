using System;

namespace Product1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"The factorial of 10 is: {factorial}");

        }
    }
}

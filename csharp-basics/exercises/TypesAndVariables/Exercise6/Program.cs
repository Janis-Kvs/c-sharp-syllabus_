using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a single digit number: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Input another single digit number: ");
            int.TryParse(Console.ReadLine(), out int b);
            Console.Write("Input another single digit number: ");
            int.TryParse(Console.ReadLine(), out int c);
            int sum = a + b + c;

            Console.WriteLine($"The sum of {a}, {b}, {c} is {sum}.");
        }
    }
}

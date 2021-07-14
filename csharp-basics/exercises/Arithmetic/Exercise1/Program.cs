using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input integer number 1: ");
            int.TryParse(Console.ReadLine(), out int number1);
            Console.WriteLine("Please input integer number 2: ");
            int.TryParse(Console.ReadLine(), out int number2);

            Console.WriteLine((number1 == 15 || number2 == 15) || (number1 + number2 == 15 || Math.Abs(number1 - number2) == 15));


        }
    }
}

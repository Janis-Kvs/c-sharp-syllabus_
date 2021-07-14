using System;

namespace CheckOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number : ");
            int.TryParse(Console.ReadLine(), out int number);
            var result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
            Console.WriteLine("bye!");
            
        }
    }
}

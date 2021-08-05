using System;

namespace CheckOddEven
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number : ");
            int.TryParse(Console.ReadLine(), out int number);
            var result = IsEven(number);
            Console.WriteLine(result);
            Console.WriteLine("bye!");
        }

        public static string IsEven(int number)
        {
            return (number % 2 == 0) ? "Even Number" : "Odd Number";
        }
    }
}

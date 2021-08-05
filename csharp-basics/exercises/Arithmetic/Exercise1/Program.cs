using System;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input integer number 1: ");
            int.TryParse(Console.ReadLine(), out int number1);
            Console.WriteLine("Please input integer number 2: ");
            int.TryParse(Console.ReadLine(), out int number2);
            Console.WriteLine(Check(Is15(number1, number2), IsSum15(number1, number2), IsDifference15(number1, number2)));
        }

        public static bool Is15(int number1, int number2)
        {
            return (number1 == 15 || number2 == 15);
        }

        public static bool IsSum15(int number1, int number2)
        {
            return (number1 + number2 == 15);
        }

        public static bool IsDifference15(int number1, int number2)
        {
            return (Math.Abs(number1 - number2) == 15);
        }

        public static bool Check(bool b1, bool b2, bool b3)
        {
            return (b1 || (b2 || b3));
        }
    }
}

using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            int.TryParse(Console.ReadLine(), out int input);
            
            if (input > 0)
            {
                Console.WriteLine("Number is positive");
            } 
            else if (input < 0) 
            {
                Console.WriteLine("Number is negative");
            } 
            else 
            {
                Console.WriteLine("Number is zero");
            }
            Console.ReadKey();
        }
    }
}

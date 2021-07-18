using System;

namespace Exercise1
{
    class Program
    {
        //The program displays the first 10 natural numbers.
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("The first 10 natural numbers are: ");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

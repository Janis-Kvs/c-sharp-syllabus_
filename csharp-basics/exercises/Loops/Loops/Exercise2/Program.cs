using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            
            Console.WriteLine("Input number of terms : ");

            n = Convert.ToInt32(Console.ReadLine());
            /*
            todo - complete loop to multiply i with itself n times, it is NOT allowed to use Math.Pow()
            */
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(Pow(i,n));
            }

            Console.ReadKey();

        }

        static int Pow(int number, int times)
        {
            var a = number;
            for (var i = times; i > 1; i--)
            {
                a *= number;
            }

            return a;
        }
    }
}

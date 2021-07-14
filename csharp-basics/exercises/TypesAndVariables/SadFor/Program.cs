using System;

namespace SadFor
{
    class Program
    {
        private static void Main(string[] args)
        {
            Test1();
            Console.ReadKey();
        }

        private static void Test1()
        {

            for (double i = 0; i < 10; i++)
            {
                if (Math.Sqrt(i) > 2.5)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
using System;
using System.Threading.Tasks.Dataflow;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter first word:");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter second word:");
            string word2 = Console.ReadLine();
            int dotCount = 30 - word1.Length - word2.Length;
            Console.Write(word1);
            for (int i = 0; i < dotCount; i++)
            {
                Console.Write(".");
            }
            Console.Write(word2);
            Console.ReadKey();
        }
    }
}

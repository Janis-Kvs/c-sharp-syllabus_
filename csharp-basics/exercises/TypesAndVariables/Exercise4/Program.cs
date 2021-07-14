using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter year of birth: ");
            int.TryParse(Console.ReadLine(), out int birthYear);

            Console.WriteLine($"My name is {name} and I was born on {birthYear}.");

        }
    }
}

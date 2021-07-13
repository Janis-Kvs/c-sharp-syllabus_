using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int birthYear;
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("enter year of birth: ");
            int.TryParse(Console.ReadLine(), out birthYear);

            Console.WriteLine($"My name is {name} and I was born on {birthYear}.");

        }
    }
}

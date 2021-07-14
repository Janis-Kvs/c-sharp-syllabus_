using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string word = Console.ReadLine();
            int numberOfUpperLetter = 0;
            foreach (char letter in word)
            {
                if (Char.IsUpper(letter)) numberOfUpperLetter++;
            }
            Console.WriteLine($"The number of upper case letters is: {numberOfUpperLetter}");
        }
    }
}

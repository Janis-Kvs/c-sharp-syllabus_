using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number of minutes by your choice: ");
            int.TryParse(Console.ReadLine(), out int minutes);
            double years = (double)minutes / 365 / 24 / 60;
            Console.WriteLine($"{minutes} minutes are {years} years");
            double days = (double)minutes / 24 / 60;
            Console.WriteLine($"{minutes} minutes are {days} days");
        }
    }
}

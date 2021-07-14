using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input distance in meters: ");
            double.TryParse(Console.ReadLine(), out double distance);
            Console.WriteLine("Input hours: ");
            double.TryParse(Console.ReadLine(), out double hours);
            Console.WriteLine("Input minutes: ");
            double.TryParse(Console.ReadLine(), out double minutes);
            Console.WriteLine("Input seconds: ");
            double.TryParse(Console.ReadLine(), out double seconds);
  
            double metersPerSecond = distance / (hours * 60 * 60 + minutes * 60 + seconds);
            double kilometersPerHour = distance / 1000 / (hours + minutes / 60 + seconds / 60 / 60);
            double milesPerHour = kilometersPerHour / 1.60934;

            Console.WriteLine("Your speed in meters / second is " + Math.Round(metersPerSecond, 3));
            Console.WriteLine("Your speed in km / h is " + Math.Round(kilometersPerHour, 3));
            Console.WriteLine("Your speed in miles / h is " + Math.Round(milesPerHour, 3));

        }
    }
}

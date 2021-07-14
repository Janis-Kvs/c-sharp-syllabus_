using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your weight in kilos: ");
            double.TryParse(Console.ReadLine(), out double weight);
            Console.WriteLine("What is your height in meters: ");
            double.TryParse(Console.ReadLine(), out double height);

            double bIndex = Math.Round(weight * 2.20462 * 703 / Math.Pow(height / 0.0254, 2), 1);

            if (bIndex is >= 18.5 and <= 25)
            {
                Console.WriteLine($"Your weight {weight} kg is considered optimal with an BMI index of {bIndex}.");
            } else if (bIndex > 25)
            {
                Console.WriteLine($"Your weight {weight} kg is considered overweight with an BMI index of {bIndex}.");
            }
            else
            {
                Console.WriteLine($"Your weight {weight} kg is considered underweight with an BMI index of {bIndex}.");
            }

        }
    }
}

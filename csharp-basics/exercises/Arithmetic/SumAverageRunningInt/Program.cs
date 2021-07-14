using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number) 
            {
                sum += number;
            }

            var average = sum / (Math.Abs(lowerBound - upperBound) + 1);

            Console.WriteLine($"The sum of {lowerBound} to {upperBound} is {sum}");
            Console.WriteLine($"The average is {average}");

            Console.ReadKey();

        }
    }
}

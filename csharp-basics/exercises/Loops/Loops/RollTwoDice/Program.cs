using System;

namespace RollTwoDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool win = false;
            Random random = new Random();
            Console.WriteLine("What is the desired sum of both dices?");
            int.TryParse(Console.ReadLine(), out int desiredSum);
            while (!win)
            {
                int randomNumber1 = random.Next(1, 7);
                int randomNumber2 = random.Next(1, 7);
                Console.WriteLine($"{randomNumber1} and {randomNumber2} are {randomNumber1 + randomNumber2}");
                if (desiredSum == randomNumber1 + randomNumber2)
                    win = true;
            }
        }
    }
}

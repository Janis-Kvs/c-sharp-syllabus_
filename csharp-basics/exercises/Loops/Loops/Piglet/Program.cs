using System;

namespace Piglet
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            bool continueGame = true;
            Random random = new Random();

            Console.WriteLine("Welcome to Piglet!");
            while (continueGame)
            {
                int randomNumber = random.Next(1, 7);
                Console.WriteLine($"You rolled a {randomNumber}");
                if (randomNumber == 1)
                {
                    continueGame = false;
                    points = 0;
                    Console.WriteLine($"Game Over :You got {points} points.");

                }
                else
                {
                    points += randomNumber;
                    Console.WriteLine($"You got {points} points.");
                    Console.Write("Roll again (y/n)?:");
                    if (Console.ReadLine() == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Game Over :You got {points} points.");
                        break;
                    }
                }
            }
        }
    }
}
using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            int.TryParse(Console.ReadLine(), out int guessNumber);

            if (guessNumber == randomNumber)
            {
                Console.WriteLine("You lucky one, you guessed the number!!!");
            } else if (guessNumber > randomNumber)
            {
                Console.WriteLine($"Sorry, you are too high.  I was thinking of {randomNumber}");
            }
            else
            {
                Console.WriteLine($"Sorry, you are too low.  I was thinking of {randomNumber}");
            }

        }
    }
}

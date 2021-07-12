using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [,] table = new int[3,4];
            //for (var t = 0; t < 3; ++t)
            //{
            //    for (var i = 0; i < 4; ++i)
            //    {
            //        table[t, i] = (t * 4) + i + 1;
            //        Console.Write(table[t, i] + " ");
            //    }
            //
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Welcome to Piglet!");
            //Console.WriteLine("Do you want to start to play?");
            //string answer = Console.ReadLine();

            //Random random = new Random();
            //int score = 0;
            //while (true)
            //{
            //    if (answer == "yes")
            //    {
            //        var randomNumber = random.Next(1, 6);

            //        if (randomNumber == 1)
            //        {
            //            Console.WriteLine("You rolled a 1! You got 0 points. The game is over");
            //            break;
            //        }
            //        score += randomNumber;
            //        Console.WriteLine($"You rolled a {randomNumber}!");
            //        Console.WriteLine(score);
            //        Console.WriteLine("Do you want to continue to play?");
            //        answer = Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Your score is {score}. The game is over.");
            //        break;
            //    }
            //}

            //Console.ReadKey();
            Console.WriteLine("Write a number from 2 till 12");
            int desiredNumber = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            var randomNumber = 0;
            var randomNumber1 = 0;
            while (randomNumber1 + randomNumber != desiredNumber)
            {
                randomNumber = random.Next(1, 6);
                randomNumber1 = random.Next(1, 6);
                
                int sum = randomNumber + randomNumber1;
                Console.WriteLine($"{randomNumber} and {randomNumber1} = {sum} ");
            }

            Console.ReadKey();
        }
    }
}

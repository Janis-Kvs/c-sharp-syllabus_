using System;
using System.Diagnostics.CodeAnalysis;

namespace Exercise8
{
    class Program
    {
        private static string[] words = new string[]
        {
            "superman", "planet", "monitor", "ventilator", "latvia", "table", "icecream", "chair", "television",
            "orange"
        };

        private static Random random = new Random();
        private static string randomWord = words[random.Next(0, words.Length)];
        private static string[] guessingWord = new string[randomWord.Length];
        private static int numOfGuesses = randomWord.Length + 6;
        private static char[] missedLetters = new char[numOfGuesses];
        private static int missedLetterIndex = 0;

        static void Main(string[] args)
        {
            Console.WriteLine(randomWord);
            InitialSetup();
            StartGame();
            if (IsWin())
            {
                Console.WriteLine("YOU GOT IT!");
                Console.Write("Play \"again\" or \"quit\"? ");
                var answer = Console.ReadLine();
                if (answer == "again") {}
                    RestartGame();
            }
            else
            {
                Console.WriteLine("YOU LOST THE GAME!");
                Console.Write("Play \"again\" or \"quit\"? ");
                var answer = Console.ReadLine();
                if (answer == "again") { }
                RestartGame();
            }
        }

        public static void RestartGame()
        {
            randomWord = words[random.Next(0, words.Length)];
            guessingWord = new string[randomWord.Length];
            numOfGuesses = randomWord.Length + 6;
            missedLetters = new char[numOfGuesses];
            missedLetterIndex = 0;
            InitialSetup();
            StartGame();
        }

        public static void StartGame()
        {
            int i = 0;
            do
            {
                DrawGame();
                IsWin();
                ++i;
            } while (i < numOfGuesses && !IsWin());
        }

        public static bool IsWin()
        {
            if (String.Concat(guessingWord) == randomWord)
            {
                return true;
            }
            return false;
        }


        public static void DrawGame()
        {
            Console.Write("Please input a letter: ");
            char.TryParse(Console.ReadLine(), out char letter);
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-c=-=-=-");
            Console.Write("Word: ");

            for (int j = 0; j < randomWord.Length; j++)
            {
                if (randomWord[j] == letter)
                {
                    guessingWord[j] = Char.ToString(randomWord[j]);
                }

                Console.Write(guessingWord[j] + " ");
            }

            if (!randomWord.Contains(letter))
            {
                missedLetters[missedLetterIndex] = letter;
                missedLetterIndex++;
            }

            Console.WriteLine();
            Console.WriteLine($"Misses: " + String.Join(' ', missedLetters));
            Console.WriteLine($"Guess: {letter}");
            Console.WriteLine();
        }

        public static void InitialSetup()
        {
            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.Write("Word: ");
            for (int i = 0; i < randomWord.Length; i++)
            {
                guessingWord[i] = "_ ";
                Console.Write(guessingWord[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"Misses: ");
            Console.WriteLine($"Guess: ");
            Console.WriteLine();
        }
    }
}
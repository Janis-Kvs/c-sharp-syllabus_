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

        private static Random _random = new Random();
        private static string _randomWord = words[_random.Next(0, words.Length)];
        private static string[] _guessingWord = new string[_randomWord.Length];
        private static int _numOfGuesses = _randomWord.Length + 6;
        private static char[] _missedLetters = new char[_numOfGuesses];
        private static int _missedLetterIndex = 0;

        static void Main(string[] args)
        {
            Console.WriteLine(_randomWord);
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
            _randomWord = words[_random.Next(0, words.Length)];
            _guessingWord = new string[_randomWord.Length];
            _numOfGuesses = _randomWord.Length + 6;
            _missedLetters = new char[_numOfGuesses];
            _missedLetterIndex = 0;
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
            } while (i < _numOfGuesses && !IsWin());
        }

        public static bool IsWin()
        {
            if (String.Concat(_guessingWord) == _randomWord) return true;
            return false;
        }


        public static void DrawGame()
        {
            Console.Write("Please input a letter: ");
            char.TryParse(Console.ReadLine(), out char letter);
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-c=-=-=-");
            Console.Write("Word: ");

            for (int j = 0; j < _randomWord.Length; j++)
            {
                if (_randomWord[j] == letter)
                {
                    _guessingWord[j] = Char.ToString(_randomWord[j]);
                }

                Console.Write(_guessingWord[j] + " ");
            }

            if (!_randomWord.Contains(letter))
            {
                _missedLetters[_missedLetterIndex] = letter;
                _missedLetterIndex++;
            }

            Console.WriteLine();
            Console.WriteLine($"Misses: " + String.Join(' ', _missedLetters));
            Console.WriteLine($"Guess: {letter}");
            Console.WriteLine();
        }

        public static void InitialSetup()
        {
            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.Write("Word: ");
            for (int i = 0; i < _randomWord.Length; i++)
            {
                _guessingWord[i] = "_ ";
                Console.Write(_guessingWord[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"Misses: ");
            Console.WriteLine($"Guess: ");
            Console.WriteLine();
        }
    }
}
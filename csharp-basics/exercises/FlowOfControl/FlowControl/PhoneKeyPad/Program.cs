using System;

namespace PhoneKeyPad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string word = Console.ReadLine()?.ToLower();
            string digitMessage = "";

            foreach (char letter in word)
            {
                if (letter == 'a' || letter == 'b' || letter == 'c')
                {
                    digitMessage += "2";
                }
                else if (letter == 'd' || letter == 'e' || letter == 'f')
                {
                    digitMessage += "3";
                }
                else if (letter == 'g' || letter == 'h' || letter == 'i')
                {
                    digitMessage += "4";
                }
                else if (letter == 'j' || letter == 'k' || letter == 'l')
                {
                    digitMessage += "5";
                }
                else if (letter == 'm' || letter == 'n' || letter == 'o')
                {
                    digitMessage += "6";
                }
                else if (letter == 'p' || letter == 'q' || letter == 'r' || letter == 's')
                {
                    digitMessage += "7";
                }
                else if (letter == 't' || letter == 'u' || letter == 'v')
                {
                    digitMessage += "8";
                }
                else if (letter == 'w' || letter == 'x' || letter == 'y' || letter == 'z')
                {
                    digitMessage += "9";
                }
                else
                {
                    digitMessage += " ";
                }
            }
            Console.WriteLine($"Your string in digit format is: {digitMessage}");
            digitMessage = "";

            foreach (char letter in word)
            {
                switch (letter)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        digitMessage += "2";
                        break;
                    case 'd':
                    case 'e':
                    case 'f':
                        digitMessage += "3";
                        break;
                    case 'g':
                    case 'h':
                    case 'i':
                        digitMessage += "4";
                        break;
                    case 'j':
                    case 'k':
                    case 'l':
                        digitMessage += "5";
                        break;
                    case 'm':
                    case 'n':
                    case 'o':
                        digitMessage += "6";
                        break;
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        digitMessage += "7";
                        break;
                    case 't':
                    case 'u':
                    case 'v':
                        digitMessage += "8";
                        break;
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        digitMessage += "9";
                        break;
                    default:
                        digitMessage += " ";
                        break;
                }
            }
            Console.WriteLine($"Your string in digit format is: {digitMessage}");
        }
    }
}

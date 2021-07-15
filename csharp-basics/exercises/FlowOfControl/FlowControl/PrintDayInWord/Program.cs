using System;

namespace PrintDayInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an integer from 1 to 7 which represents a weeks day: ");
            Int32.TryParse(Console.ReadLine(), out int input);

            if (input == 1)
            {
                Console.WriteLine("Your selected day is Monday");
            } 
            else if (input == 2)
            {
                Console.WriteLine("Your selected day is Tuesday");
            }
            else if (input == 3)
            {
                Console.WriteLine("Your selected day is Wednesday");
            }
            else if (input == 4)
            {
                Console.WriteLine("Your selected day is Thursday");
            }
            else if (input == 5)
            {
                Console.WriteLine("Your selected day is Friday");
            }
            else if (input == 6)
            {
                Console.WriteLine("Your selected day is Saturday");
            }
            else if (input == 7)
            {
                Console.WriteLine("Your selected day is Sunday");
            }
            else
            {
                Console.WriteLine("Not a valid day");
            }

            switch (input)
            {
                case 1:
                    Console.WriteLine("Your selected day is Monday");
                    break;
                case 2:
                    Console.WriteLine("Your selected day is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Your selected day is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Your selected day is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Your selected day is Friday");
                    break;
                case 6:
                    Console.WriteLine("Your selected day is Saturday");
                    break;
                case 7:
                    Console.WriteLine("Your selected day is Sunday");
                    break;
                default:
                    Console.WriteLine("Not a valid day");
                    break;
            }
        }
    }
}

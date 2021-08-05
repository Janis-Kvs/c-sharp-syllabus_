using System;

namespace CozaLozaWoza
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 110; i++)
            {

                Console.Write(GetName(i));
                if (i % 11 == 0)
                {
                    Console.Write("\n");
                }
            }

        }

        public static string GetName(int i)
        {
            if (i % 5 == 0 && i % 3 == 0 && i % 7 == 0)
            {
                return "CozaLozaWoza ";
            }
            else if (i % 5 == 0 && i % 3 == 0)
            {
                return  "CozaLoza ";
            }
            else if (i % 5 == 0 && i % 7 == 0)
            {
                return "LozaWoza ";
            }
            else if (i % 3 == 0 && i % 7 == 0)
            {
                return "CozaWoza ";
            }
            else if (i % 5 == 0)
            {
                return "Loza ";
            }
            else if (i % 3 == 0)
            {
                return "Coza ";
            }
            else if (i % 7 == 0)
            {
                return "Woza ";
            }
            else
            {
                return i + " ";
            }
        }


    }
}

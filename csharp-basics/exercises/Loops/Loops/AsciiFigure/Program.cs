using System;

namespace AsciiFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many levels should the *AsciiFigure* have: ");
            int.TryParse(Console.ReadLine(), out int levels);

            int i = 1;
            string symbol = "";

            while ( i <= levels)
            {
                string dash1 = new string('/', 4 * (levels - i));
                string dash2 = new string('\\', 4 * (levels - i));
                Console.WriteLine(dash1 + symbol + dash2);
                symbol += "********";
                i++;
            }

        }
    }
}

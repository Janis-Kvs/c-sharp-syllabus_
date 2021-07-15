using System;

namespace Exercise4
{
    class Program
    {
        //TODO: Write a C# program to test if an array contains a specific value.
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            for (int i = 0; i < myArray.Length; i++ )
            {
                bool result = (myArray[i] == 1245);
                if (result)
                {
                    Console.WriteLine("Contains!");
                }
            }
            Console.ReadKey();
        }
    }
}

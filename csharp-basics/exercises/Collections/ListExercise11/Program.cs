using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                names.Add($"name{i+1}");
            }

            names[4] = "added new value to 5th position";
            names[names.Count - 1] = "Change value at last position";
            names.Sort();
            bool result = names.Contains("Foobar");
            Console.WriteLine($"List contains \"Foobar\": {result}");
           
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadKey();
        }
    }
}

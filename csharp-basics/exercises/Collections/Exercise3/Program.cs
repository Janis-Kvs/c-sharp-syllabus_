using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "j";
            HashSet<string> nameHashSet = new HashSet<string>();

            while (name != string.Empty)
            {
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
                nameHashSet.Add(name);
            }
            Console.WriteLine($"Unique name list contains: {String.Join(',', nameHashSet)}");
        }
    }
}

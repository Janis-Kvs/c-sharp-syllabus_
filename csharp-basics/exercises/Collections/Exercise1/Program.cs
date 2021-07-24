using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> list = new List<string>(array);
            foreach (string el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine();
            HashSet<string> hashSet = new HashSet<string>(array);
            foreach (string el in hashSet)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine();
            Console.WriteLine("Origination:");
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Audi", "Germany");
            dictionary.Add("BMW", "Germany");
            dictionary.Add("Honda", "Japan");
            dictionary.Add("Mercedes", "Germany");
            dictionary.Add("VolksWagen", "Germany");
            dictionary.Add("Tesla", "USA");
            foreach (KeyValuePair<string, string> kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            Console.ReadKey();
        }
    }
}

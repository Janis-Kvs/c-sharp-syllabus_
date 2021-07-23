using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            var numberArray = readText[0].Split(' ');
            List<int> numberList = new List<int>();
            Dictionary<string, string> histogram = new Dictionary<string, string>();

            //Create List of integers
            foreach (var s in numberArray)
            {
                numberList.Add(int.Parse(s));
            }

            //Create dictionary with appropriate keys
            string[] keys =
                {"00-09", "10-19", "20-29", "30-39", "40-49", "50-59", "60-69", "70-79", "80-89", "90-99", "100"};
            foreach (var key in keys)
            {
                histogram.Add(key, "");
            }

            //Iterate through each number in Lit and add it to appropriate dictionary key
            foreach (var num in numberList)
            {
                if (num <= 9)
                    histogram["00-09"] += "*";
                else if (num <= 19)
                    histogram["10-19"] += "*";
                else if (num <= 29)
                    histogram["20-29"] += "*";
                else if (num <= 39)
                    histogram["30-39"] += "*";
                else if (num <= 49)
                    histogram["40-49"] += "*";
                else if (num <= 59)
                    histogram["50-59"] += "*";
                else if (num <= 69)
                    histogram["60-69"] += "*";
                else if (num <= 79)
                    histogram["70-79"] += "*";
                else if (num <= 89)
                    histogram["80-89"] += "*";
                else if (num <= 99)
                    histogram["90-99"] += "*";
                else if (num == 100)
                    histogram["100"] += "*";
            }

            //Display key - value pairs
            foreach (var element in histogram)
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int charact = 0;
            string text = File.ReadAllText(@"../../lear.txt");

            //Count lines
            string[] linesArray = text.Split('\r','\n');
            List<string> linesList = new List<string>(linesArray);
            linesList.RemoveAll(item => item == "");
            Console.WriteLine("Lines = " + linesList.Count);

            //Count words
            string[] wordsArray = text.Split(' ', '\'', '\r', '\n');
            List<string> wordsList = new List<string>(wordsArray);
            wordsList.RemoveAll(item => item == "");
            Console.WriteLine("Words = " + wordsList.Count);

            //Count characters
            foreach (var ch in linesArray)
            {
                charact += ch.Length;
            }
            Console.WriteLine("Characters = " + charact);
            Console.ReadLine();
        }
    }
}

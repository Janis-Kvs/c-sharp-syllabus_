using System;
using System.Collections.Generic;
using System.IO;

namespace WordCount
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"../../lear.txt");
            Console.WriteLine(CountLines(text));//Count lines
            Console.WriteLine(CountWords(text));//Count words
            Console.WriteLine(CountCharacters(text)); //Count characters
            Console.ReadLine();
        }

        public static string CountLines(string text)
        {
            string[] linesArray = text.Split('\r', '\n');
            List<string> linesList = new List<string>(linesArray);
            linesList.RemoveAll(item => item == "");
            return "Lines = " + linesList.Count;
        }

        public static string CountWords(string text)
        {
            string[] wordsArray = text.Split(' ', '\'', '\r', '\n');
            List<string> wordsList = new List<string>(wordsArray);
            wordsList.RemoveAll(item => item == "");
            return "Words = " + wordsList.Count;
        }

        public static string CountCharacters(string text)
        {
            int charact = 0;
            string[] linesArray = text.Split('\r', '\n');
            foreach (var ch in linesArray)
            {
                charact += ch.Length;
            }
            return "Characters = " + charact;
        }
    }
}

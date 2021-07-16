using System;
using System.Collections.Generic;

namespace NumberSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Min ? ");
            int.TryParse(Console.ReadLine(), out var number1);
            Console.Write("Max ? ");
            int.TryParse(Console.ReadLine(), out var number2);
            List<int> numberList = new List<int>();
            for (int i = number1; i <= number2; i++)
            {
                Console.Write(i);
                numberList.Add(i);
            }

            do
            {
                Console.WriteLine();
                int firstNumber = numberList[0];
                for (int i = 0; i < numberList.Count; i++)
                {
                    if (i != numberList.Count - 1)
                    {
                        numberList[i] = numberList[i + 1];
                    }
                    else
                    {
                        numberList[i] = firstNumber;
                    }
                    Console.Write(numberList[i]);
                }
            } while (numberList[0] != number2);
        }
    }
}

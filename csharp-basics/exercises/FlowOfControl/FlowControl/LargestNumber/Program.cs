using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the 1st number: ");
            int.TryParse(Console.ReadLine(), out int input1);

            Console.Write("Input the 2nd number: ");
            int.TryParse(Console.ReadLine(), out int input2);

            Console.Write("Input the 3rd number: ");
            int.TryParse(Console.ReadLine(), out int input3);

            int maxNumber = input1 >= input2 ? input1 : input2;
            maxNumber = maxNumber >= input3 ? maxNumber : input3;

            Console.WriteLine($"The largest number of {input1}, {input2}, {input3} is {maxNumber}");
            Console.ReadKey();
        }
    }
}

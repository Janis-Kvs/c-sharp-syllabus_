using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            Random random = new Random();

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(1, 101);
            }

            array1.CopyTo(array2, 0);
            array2[^1] = -7;
            Console.WriteLine("Array 1: "+ string.Join(' ', array1));
            Console.WriteLine("Array 2: " + string.Join(' ', array2));
        }
    }
}

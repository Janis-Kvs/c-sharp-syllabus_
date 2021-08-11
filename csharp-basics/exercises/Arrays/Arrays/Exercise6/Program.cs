 using System;

namespace Exercise6
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            Random random = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(1, 101);
            }

            Console.WriteLine("Array 1: "+ string.Join(' ', array1));
            var array2 = CopyArray(array1);
            ChangeLast(array2);
            Console.WriteLine("Array 2: " + string.Join(' ', array2));
        }

        public static int[] CopyArray(int[] array)
        {
            int[] array2 = new int[10];
            array.CopyTo(array2, 0);
            return array2;
        }

        public static int[] ChangeLast(int[] array)
        {
            array[^1] = -7;
            return array;
        }
    }
}

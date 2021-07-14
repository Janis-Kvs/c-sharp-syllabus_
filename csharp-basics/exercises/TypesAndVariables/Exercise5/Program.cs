using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many classes do you have?");
            int.TryParse(Console.ReadLine(), out int classCount);
            string[] classNames = new string[classCount];
            string[] classTeachers = new string[classCount];
            for (int i = 1; i <= classCount; i++)
            {
                Console.Write($"What is the name of class number {i}: ");
                classNames[i - 1] = Console.ReadLine();
                Console.Write($"What is the teachers name of class number {i}: ");
                classTeachers[i - 1] = Console.ReadLine();
            }

            Console.WriteLine("+------------------------------------------------------------+");
            for (int i = 1; i <= classCount; i++)
            {
                string classNumber = $"| {i} |";
                int spaceCountClass = 35- classNames[i-1].Length;
                string className = new string(' ', spaceCountClass);
                className += $"{classNames[i-1]} |";
                int spaceCountTeacher = 18 - classTeachers[i-1].Length;
                string classTeacher = new string(' ', spaceCountTeacher);
                classTeacher += $"{classTeachers[i-1]} |";

                Console.WriteLine(classNumber + className + classTeacher);
            }

            Console.WriteLine("+------------------------------------------------------------+");

            //Table is aligned till 9 "classes"
        }
    }
}

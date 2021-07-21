using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Exercise7
{
    class DogTest
    {

        private static  List<Dog> _dogs = new List<Dog>();

        public static void Main(string[] args)
        {
            string[,] dogArray1 =
            {
                {"Max", "male", "Lady", "Rocky"},
                {"Rocky", "male", "Molly", "Sam"},
                {"Buster", "male", "Lady", "Sparky"},
                {"Coco", "female", "Molly", "Buster"}
            };

            string[,] dogArray2 =
            {
                {"Sparky", "male"},
                {"Sam", "male"},
                {"Lady", "female"},
                {"Molly", "female"}
            };

            for (int i = 0; i < dogArray1.GetLength(0); i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    _dogs.Add(new Dog(dogArray1[i, 0], dogArray1[i, 1], dogArray1[i, 2],dogArray1[i, 3]));
                }
            }

            for (int i = 0; i < dogArray2.GetLength(0); i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    _dogs.Add(new Dog(dogArray2[i, 0], dogArray2[i, 1]));
                }
            }

            Console.WriteLine("The fathers name of Coco is "+ FindDog("Coco").FathersName());
            Console.WriteLine("The fathers name of Coco is " + FindDog("Sparky").FathersName());

            Console.WriteLine("Coco has the same mother as Rocky: " + FindDog("Coco").HasSameMotherAs(FindDog("Rocky")));
        }

        public static Dog FindDog(string name)
        {
            foreach (Dog dog in _dogs)
            {
                if (dog.Name == name)
                    return dog;
            }

            return null;
        }

    }
}

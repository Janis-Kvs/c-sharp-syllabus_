using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            String eyes;
            String teeth;
            String hair;
            int age;
            double height;
            double weight;
            
            name = "Zed A. Shaw";
            eyes = "Blue";
            teeth = "White";
            hair = "Brown";
            age = 35;
            height = Math.Round(74 * 2.54, 2);  // cm
            weight = Math.Round(180 * 0.453592, 2); // kg
           

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + height + " centimeters tall.");
            Console.WriteLine("He's " + weight + " kilos heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight
                               + " I get " + (age + height + weight) + ".");

            Console.ReadKey();
            

        }
    }
}
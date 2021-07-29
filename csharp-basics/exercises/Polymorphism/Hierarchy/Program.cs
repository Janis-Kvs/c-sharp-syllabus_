using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks.Dataflow;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string answer3;
            int i = 0;
            
            do
            {
                Console.WriteLine("Please input the animals type(Zebra, Mouse, Tiger, Cat), name, weight, living region and breed(only for cats).\n" +
                                  "Separate the words with whitespaces");
                string[] answer = Console.ReadLine().Split(' ');

                if (answer[0].ToLower() == "cat")
                {
                    animals.Add(new Cat(answer[1], answer[0], double.Parse(answer[2], CultureInfo.InvariantCulture), answer[3], answer[4]));
                }
                else if (answer[0].ToLower() == "tiger")
                {
                    animals.Add(new Tiger(answer[1], answer[0], double.Parse(answer[2], CultureInfo.InvariantCulture), answer[3]));
                }
                else if (answer[0].ToLower() == "zebra")
                {
                    animals.Add(new Zebra(answer[1], answer[0], double.Parse(answer[2], CultureInfo.InvariantCulture), answer[3]));
                }
                else if (answer[0].ToLower() == "mouse")
                {
                    animals.Add(new Mouse(answer[1], answer[0], double.Parse(answer[2], CultureInfo.InvariantCulture), answer[3]));
                }

                animals[i].MakeSound();
                Console.WriteLine("Please provide the food (vegetable or meat) and quantity for the animal.\n" +
                                  "Separate the words with whitespaces");
                string[] answer2 = Console.ReadLine().Split(' ');

                if (answer2[0].ToLower() == "vegetable")
                {
                    Food food = new Vegetable(int.Parse(answer2[1]));
                    animals[i].Eat(food);
                } 
                else if (answer2[0].ToLower() == "meat")
                {
                    Food food = new Meat(int.Parse(answer2[1]));
                    animals[i].Eat(food);
                }

                Console.WriteLine(animals[i]);
                i++;
                Console.WriteLine("Do you want to add more animals? Yes/End");
                answer3 = Console.ReadLine().ToLower();
            } while (answer3 != "end");

            string res = String.Join(", ", animals);
            Console.WriteLine(res);
        }
    }
}
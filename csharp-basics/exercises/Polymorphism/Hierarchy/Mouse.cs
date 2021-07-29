using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Piii-Piii");
        }

        public override void Eat(Food food)
        {
            if (food.ToString() == "Vegetable")
            {
                _foodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{_animalType} are not eating that type of food!");
            }
        }

        public override string ToString()
        {
            return $"{_animalType} [{_animalName}, {_animalWeight}, {_livingRegion}, {_foodEaten}]";
        }
    }
}

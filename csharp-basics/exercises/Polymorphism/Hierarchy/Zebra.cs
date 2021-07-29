﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bark-Bark");
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

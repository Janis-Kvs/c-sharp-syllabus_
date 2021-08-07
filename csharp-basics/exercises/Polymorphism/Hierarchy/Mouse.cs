﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "Piii-Piii";
        }

        public override int Eat(Food food)
        {
            if (food.ToString() == "Vegetable")
            {
                _foodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{_animalType} are not eating that type of food!");
            }

            return _foodEaten;
        }

        public override string ToString()
        {
            return $"{_animalType} [{_animalName}, {_animalWeight}, {_livingRegion}, {_foodEaten}]";
        }
    }
}

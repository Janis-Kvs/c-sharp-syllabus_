using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Cat : Felime
    {
        private string _breed;

        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breed) : base(animalName, animalType, animalWeight, livingRegion)
        {
            _breed = breed;
        }

        public override string MakeSound()
        {
            return "Meowwww";
        }

        public override int Eat(Food food)
        {
           _foodEaten += food.Quantity;
           return _foodEaten;
        }

        public override string ToString()
        {
            return $"{_animalType} [{_animalName}, {_breed}, {_animalWeight}, {_livingRegion}, {_foodEaten}]";
        }
    }
}

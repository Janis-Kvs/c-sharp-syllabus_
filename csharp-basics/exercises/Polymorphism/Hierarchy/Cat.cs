using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Cat : Felime
    {
        private string _breed;

        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breed) : base(animalName, animalType, animalWeight, livingRegion)
        {
            _breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void Eat(Food food)
        {
           _foodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{_animalType} [{_animalName}, {_breed}, {_animalWeight}, {_livingRegion}, {_foodEaten}]";
        }
    }
}

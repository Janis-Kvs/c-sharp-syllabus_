using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Animal
    {
        protected string _animalName;
        protected string _animalType;
        protected double _animalWeight;
        protected int _foodEaten;

        protected Animal(string animalName, string animalType, double animalWeight)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeight = animalWeight;
            _foodEaten = 0;
        }

        public abstract string MakeSound();

        public virtual int Eat(Food food)
        {
            return _foodEaten;
        }
    }
}

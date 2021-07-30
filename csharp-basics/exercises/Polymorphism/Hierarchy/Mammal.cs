using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        protected string _livingRegion;

        protected Mammal(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight)
        {
            _livingRegion = livingRegion;
        }
    }
}

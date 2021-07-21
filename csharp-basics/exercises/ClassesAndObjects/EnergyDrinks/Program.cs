using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int _numberedSurveyed = 12467;
        private const double _purchasedEnergyDrinks = 0.14;
        private const double _preferCitrusDrinks = 0.64;

        static void Main(string[] args)
        {
            Console.WriteLine("Total number of people surveyed " + _numberedSurveyed);
            Console.WriteLine("Approximately " + CalculateEnergyDrinkers(_numberedSurveyed) + " customers bought at least one energy drink");
            Console.WriteLine(CalculatePreferCitrus(_numberedSurveyed) + " of those " + "prefer citrus flavored energy drinks.");
            Console.ReadKey();
        }

        static int CalculateEnergyDrinkers(int numberSurveyed)
        {
            int energyDrinkers = (int)(numberSurveyed * _purchasedEnergyDrinks);
            return energyDrinkers;
        }

         static int CalculatePreferCitrus(int numberSurveyed)
        {
            int preferCitrus = (int)(numberSurveyed * _purchasedEnergyDrinks * _preferCitrusDrinks);
            return preferCitrus;
        }
    }
}

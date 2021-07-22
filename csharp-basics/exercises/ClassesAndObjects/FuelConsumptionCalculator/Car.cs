using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        public double startKilometers;
        private double _endKilometers;
        private double _liters;
        public Car(double startOdo)
        {
            startKilometers = startOdo;
        }
        public double CalculateConsumption()
        {
            double consumption = _liters * 100 / (_endKilometers - startKilometers);
            return Math.Round(consumption, 2);
        }
        public bool GasHog()
        {
            return CalculateConsumption() > 15;
        }
        public bool EconomyCar()
        {
            return CalculateConsumption() < 5;
        }
        public void FillUp(int endingOdo, double liters)
        {
            _endKilometers = endingOdo;
            _liters = liters;
        }
    }
}

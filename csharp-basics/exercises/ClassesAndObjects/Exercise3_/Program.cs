using System;

namespace Exercise3_
{
    class Program
    {
        static void Main(string[] args)
        {
            FuelGauge fuelGauge = new FuelGauge();
            Odometer odometer = new Odometer(fuelGauge);
            
            for (int i = 0; i < 60; i++)
            {
                fuelGauge.IncrementFuel();
            }

            do
            {
                odometer.IncrementMilage();
                Console.WriteLine($"The current mileage: {odometer.ReportMilage()} The current fuel amount: {fuelGauge.ReportFuelAmount()} liters");
            } while (fuelGauge.ReportFuelAmount() != 0);
        }
    }
}

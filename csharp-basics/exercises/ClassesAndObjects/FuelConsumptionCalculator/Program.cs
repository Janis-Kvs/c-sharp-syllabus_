using System;
using System.Collections.Generic;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Console.WriteLine("How many cars do you have?");
            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                Console.WriteLine($"Enter car number {i + 1} odometer start reading: ");
                int odometerStart = int.Parse(Console.ReadLine());
                
                cars.Add(new Car(odometerStart));

                Console.WriteLine("How many fillups did you have?");
                int fuelCount = int.Parse(Console.ReadLine());

                for (int j = 0; j < fuelCount; j++)
                {
                    Console.WriteLine($"Enter car number {i + 1} odometer end reading for fillup number {j + 1}: ");
                    int odometerEnd = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Enter car number {i + 1} liters consumed between odometer start and end readings: ");
                    int liters = int.Parse(Console.ReadLine());
                    cars[i].FillUp(odometerEnd, liters);
                    
                    Console.WriteLine($"Car {i} fuel consumption is {cars[i].CalculateConsumption()} l / 100 km");

                    if (cars[i].GasHog())
                    {
                        Console.WriteLine($"Car {i + 1} is a gas hog");
                    }
                    else if (cars[i].EconomyCar())
                    {
                        Console.WriteLine($"Car {i + 1} is an economy car");
                    }
                    else
                    {
                        Console.WriteLine($"Car {i + 1} has an average fuel consumption");
                    }

                    cars[i].startKilometers = odometerEnd;
                }
            }
            Console.ReadKey();
        }
    }
}

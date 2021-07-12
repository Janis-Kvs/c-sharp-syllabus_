using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("new odometer");
            var fuelGauge = new FuelGauge();
            for (int i = 0; i < 30; i++)
            {
                fuelGauge.Fill();
            }

            Console.WriteLine($"fuel level:{fuelGauge.ReportLevel()}");
            var odometer = new Odometer(fuelGauge);
            Console.WriteLine("running...");
            for (int i = 0; i < 200; i++)
            {
                odometer.Increment();
                Console.WriteLine($"odometer report:{odometer.Report()} fuel report: {fuelGauge.ReportLevel()}");
            }
            Console.ReadKey();
        }        
    }
}

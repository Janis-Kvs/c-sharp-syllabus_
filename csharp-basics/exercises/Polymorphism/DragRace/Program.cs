using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            Tesla t = new Tesla();
            Audi a = new Audi();
            Bmw b = new Bmw();
            Lexus l = new Lexus();
            Volvo v = new Volvo();
            Opel o = new Opel();

            for (int i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    l.UseNitrousOxideEngine();
                    v.UseNitrousOxideEngine();
                    t.SpeedUp();
                    a.SpeedUp();
                    b.SpeedUp();
                    o.SpeedUp();
                }
                else
                {
                    t.SpeedUp();
                    a.SpeedUp();
                    b.SpeedUp();
                    l.SpeedUp();
                    o.SpeedUp();
                    v.SpeedUp();
                }

                Console.WriteLine($"Tesla speed: {t.ShowCurrentSpeed()} Audi speed: {a.ShowCurrentSpeed()} BMW speed: {b.ShowCurrentSpeed()} " +
                                  $"Lexus speed: {l.ShowCurrentSpeed()} Volvo speed: {v.ShowCurrentSpeed()} Opel speed: {o.ShowCurrentSpeed()}");
            }

            var cars = new Dictionary<string, int>
            {
                {"Tesla", t.ShowCurrentSpeed()},
                {"Audi", a.ShowCurrentSpeed()},
                {"BMW", b.ShowCurrentSpeed()},
                {"Lexus", l.ShowCurrentSpeed()},
                {"Volvo", v.ShowCurrentSpeed()},
                {"Opel", o.ShowCurrentSpeed()}
            };

            var maxValue = cars.Values.Max();
            var keyOfMaxValue = cars.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine($"The fastest car is {keyOfMaxValue} with a speed of {maxValue} km/h");
            Console.ReadKey();
        }
    }
}
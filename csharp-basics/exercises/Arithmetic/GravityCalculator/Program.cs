
using System;

namespace GravityCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = GetPosition(fallingTime, initialVelocity, initialPosition);
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }

        public static double GetPosition(double fallingTime, double initialVelocity, double initialPosition)
        {
            double gravity = -9.81;
            return 0.5 * gravity * Math.Pow(fallingTime, 2) + initialVelocity * fallingTime + initialPosition;
        }
    }
}

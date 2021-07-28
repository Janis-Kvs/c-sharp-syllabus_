using System;

namespace DragRace
{
    public class Lexus : ICar, IBoostable
    {
        private int _currentSpeed = 0;

        public void SpeedUp() 
        {
            _currentSpeed++;
        }

        public void SlowDown() 
        {
            _currentSpeed--;
        }

        public int ShowCurrentSpeed() 
        {
            return _currentSpeed;
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed+=5;
        }
    }
}
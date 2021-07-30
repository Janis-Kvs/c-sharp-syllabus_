using System;

namespace DragRace
{
    public class Tesla : ICar
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
            Console.WriteLine("-- silence ---");
        }
    }
}
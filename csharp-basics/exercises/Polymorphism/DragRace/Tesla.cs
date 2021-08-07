using System;

namespace DragRace
{
    public class Tesla : ICar
    {
        private int _currentSpeed = 0;

        public int SpeedUp()
        {
            _currentSpeed++;
            return _currentSpeed;
        }

        public int SlowDown()
        {
            _currentSpeed--;
            return _currentSpeed;
        }

        public int ShowCurrentSpeed()
        {
            return _currentSpeed;
        }

        public string StartEngine()
        {
            return "----silence----";
        }
    }
}
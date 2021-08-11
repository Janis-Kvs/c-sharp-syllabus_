using System;

namespace DragRace
{
    public class Lexus : ICar, IBoostable
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
            return "Rrrrrrr.....";
        }

        public int UseNitrousOxideEngine()
        {
            _currentSpeed+=5;
            return _currentSpeed;
        }
    }
}
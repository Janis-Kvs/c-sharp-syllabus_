using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    class Volvo : ICar, IBoostable
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
            _currentSpeed += 4;
        }
    }
}

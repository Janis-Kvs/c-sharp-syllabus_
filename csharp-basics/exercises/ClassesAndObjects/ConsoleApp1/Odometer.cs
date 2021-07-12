using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Odometer
    {
        public Odometer(FuelGauge fuelGauge)
        {
            _fuelGauge = fuelGauge;
        }

        private readonly FuelGauge _fuelGauge;
        private int _currentMilage;

        public int Report()
        {
            return _currentMilage;
        }

        public void Increment()
        {
            if (_fuelGauge.ReportLevel() <= 0) return;
            
            if (_currentMilage == 1000000)
            {
                _currentMilage = 0;
            }
            _currentMilage++;
            
            if (_currentMilage % 10 == 0)
            {
                _fuelGauge.DecreaseLevel();
            }
        }
    }
}

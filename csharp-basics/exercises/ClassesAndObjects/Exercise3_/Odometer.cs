using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_
{
    class Odometer
    {
        private int _milage;
        private FuelGauge _fuelGauge;

        public Odometer(FuelGauge fuelGauge)
        {
            _fuelGauge = fuelGauge;
        }

        public int ReportMilage()
        {
            return _milage;
        }

        public void IncrementMilage()
        {

            if (_milage < 999999)
            {
                _milage++;
                if(_milage % 10 == 0)
                    _fuelGauge.DecrementFuel();
            }
            else
            {
                _milage = 0;
            }
        }
    }
}

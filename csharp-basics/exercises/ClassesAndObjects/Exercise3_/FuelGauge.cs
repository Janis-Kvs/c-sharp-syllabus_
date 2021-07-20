﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_
{
    class FuelGauge
    {
        private int _fuelAmount;

        public int ReportFuelAmount()
        {
            return _fuelAmount;
        }

        public void IncrementFuel()
        {

            if (_fuelAmount < 70)
            {
                _fuelAmount++;
            }
            else
            {
                Console.WriteLine("The tank is full");
            }
        }
        public void DecrementFuel()
        {

            if (_fuelAmount > 0)
            {
                _fuelAmount--;
            }
        }

    }
}

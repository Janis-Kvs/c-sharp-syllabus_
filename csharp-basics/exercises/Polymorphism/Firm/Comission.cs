using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    class Comission : Hourly
    {
        private double _totalSales;
        private double _comissionRate;

        public Comission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double comissionRate)
            : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _comissionRate = comissionRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales = totalSales;
        }
        public override double Pay()
        {
            var payment = base.Pay() + _totalSales*_comissionRate;
            _totalSales = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\n'Total sales: " + _totalSales;
            return result;
        }
    }
}

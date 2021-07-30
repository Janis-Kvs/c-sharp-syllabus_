using System;

namespace Firm
{
    public class Employee : StaffMember
    {
        private string _socialSecurityNumber;
        protected double _payRate;

        public Employee(string eName, string eAddress, string ePhone,
            string socSecNumber, double rate) : base(eName, eAddress, ePhone)
        {
            _socialSecurityNumber = socSecNumber;
            _payRate = rate;
        }

         public override string ToString() 
        {
             var result = base.ToString();
             result += "\nSocial Security Number: " + _socialSecurityNumber;
             return result;
         }

        public override double Pay()
        {
            return _payRate;
        }
    }
}
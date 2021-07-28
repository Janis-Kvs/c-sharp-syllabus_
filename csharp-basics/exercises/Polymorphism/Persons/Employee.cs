using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Employee : Person
    {
        private string _jobTitle;

        public Employee(string firstName, string lastName, string address, int id, string jobTitle) : base(firstName, lastName, address, id)
        {
            _jobTitle = jobTitle;
        }
        public string JobTitle
        {
            get => _jobTitle;
            protected set => _jobTitle = value;
        }

        public override void Display()
        {
            Console.WriteLine($"First name: {FirstName}\nLast name: {LastName}\nAddress: {Address}\nId: {Id}\nJob title: {JobTitle}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Persons
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;

        public Person(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }

        public string FirstName
        {
            get => _firstName;
            protected set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            protected set => _lastName = value;
        }

        public string Address
        {
            get => _address;
            protected set => _address = value;
        }

        public int Id
        {
            get => _id;
            protected set => _id = value;
        }

        public virtual void Display()
        {
            Console.WriteLine($"First name: {FirstName}\nLast name: {LastName}\nAddress: {Address}\nId: {Id}");
        }
    }
}

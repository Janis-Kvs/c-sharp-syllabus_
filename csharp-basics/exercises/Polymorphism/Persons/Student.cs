using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Student : Person
    {
        private double _gpa;

        public Student(string firstName, string lastName, string address, int id) : base(firstName, lastName, address, id)
        {
        }
        public double GPA
        {
            get => _gpa;
            protected set => _gpa = value;
        }

        public void SetGPA(double gpa)
        {
            GPA = gpa;
        }

        public override void Display()
        {
            Console.WriteLine($"First name: {FirstName}\nLast name: {LastName}\nAddress: {Address}\nId: {Id}\nGPA: {GPA}");
        }
    }
}

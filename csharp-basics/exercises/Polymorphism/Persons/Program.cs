using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Student janisStudent = new Student("Janis", "Kazjonovs", "Dammes 33", 123);
            Employee janisEmployee = new Employee("Janis", "Kazjonovs", "Āleksandra Čaka 33", 789, "Programmētājs");
            janisStudent.SetGPA(4.5);
            janisStudent.Display();
            janisEmployee.Display();
        }
    }
}
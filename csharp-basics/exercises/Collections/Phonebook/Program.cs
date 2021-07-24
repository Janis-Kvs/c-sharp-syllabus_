using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phoneDirectory = new PhoneDirectory();
            phoneDirectory.PutNumber("Janis", "26590735");
            phoneDirectory.PutNumber("Evija", "24561238");
            phoneDirectory.PutNumber("Peteris", "21235462");
            phoneDirectory.PutNumber("Karlis", "26545435");
            phoneDirectory.PutNumber("Zane", "22246555");

            Console.WriteLine(phoneDirectory.GetNumber("Evija"));
            phoneDirectory.ListNumbers();

            Console.ReadKey();
        }
    }
}

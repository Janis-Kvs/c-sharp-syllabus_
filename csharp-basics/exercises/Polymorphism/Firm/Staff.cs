using System;

namespace Firm
{
    public class Staff
    {
        StaffMember[] staffArray;

        public Staff()
        {
            staffArray = new StaffMember[8];
            staffArray[0] = new Executive("Sam", "123 Main Line",
                "555-0469", "123-45-6789", 2423.07);
            staffArray[1] = new Employee("Carla", "456 Off Line",
                "555-0101", "987-65-4321", 1246.15);
            staffArray[2] = new Employee("Woody", "789 Off Rocker",
                "555-0000", "010-20-3040", 1169.23);
            staffArray[3] = new Hourly("Diane", "678 Fifth Ave.",
                "555-0690", "958-47-3625", 10.55);
            staffArray[4] = new Volunteer("Norm", "987 Suds Blvd.",
                "555-8374");
            staffArray[5] = new Volunteer("Cliff", "321 Duds Lane",
                "555-7282");
            staffArray[6] = new Comission("Janis", "Dammes 33",
                "165-1234","489-25-4566",6.25,0.2);
            staffArray[7] = new Comission("Evija", "Aleksandrs Caka 33",
                "123-9795", "489-25-4566", 69.75, 0.15);
            ((Executive) staffArray[0]).AwardBonus(500.00);
            ((Hourly) staffArray[3]).AddHours(40);
            ((Comission)staffArray[6]).AddHours(35);
            ((Comission)staffArray[6]).AddSales(400);
            ((Comission)staffArray[7]).AddHours(40);
            ((Comission)staffArray[7]).AddSales(950);
        }

        public void Payday()
        {
            foreach (var staff in staffArray)
            {
                Console.WriteLine(staff);
                var amount = staff.Pay();
                if (amount == 0.00)
                    Console.WriteLine("Thanks!");
                else
                    Console.WriteLine("Paid: " + amount);
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";
        static Dictionary<string, string> flightDictionary = ConvertPathToDictonary();

        private static void Main(string[] args)
        {
            
            List<string> flightCities = new List<string>();

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");
            var answer = Console.ReadLine();

            if (answer == "1")
            {
                DisplayDestinations();
            }
            else return;
            
            Console.WriteLine("\nTo select a city from which you would like to start press 1");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                DisplayDepartures();
            } else return;

            Console.WriteLine("\nDeparture city: ");
            answer = Console.ReadLine();
            if(flightDictionary.ContainsKey(answer))
                flightCities.Add(answer);

            Console.WriteLine("\nNext city to fly to:");
            Console.WriteLine("Choose from: " + flightDictionary[answer]);
            var nextCity = Console.ReadLine();
            flightCities.Add(nextCity);
            
            do
            {
                Console.WriteLine("\nNext city to fly to:");
                Console.WriteLine("Choose from: " + flightDictionary[nextCity]);
                nextCity = Console.ReadLine();
                flightCities.Add(nextCity);
            } while (nextCity != answer);
            
            Console.WriteLine("\nYou made a roundtrip:");
            foreach (var destination in flightCities)
            {
                Console.WriteLine(destination);
            }
            
            Console.ReadKey();
        }

        public static Dictionary<string, string> ConvertPathToDictonary()
        {
            string[] flights = File.ReadAllLines(Path);
            string[] stringSeparators = { "->" };
            Dictionary<string, string> flightDictionary = new Dictionary<string, string>();
            List<string> flightCities = new List<string>();

            foreach (var s in flights)
            {
                //Each flight line is separated in an array
                string[] flightArray = s.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < flightArray.Length; i++)
                {
                    string elementTrim = flightArray[i].Trim();
                    flightArray[i] = elementTrim;
                }

                //Each flight line array is put in dictionary
                if (!flightDictionary.ContainsKey(flightArray[0]))
                {
                    flightDictionary.Add(flightArray[0], flightArray[1]);
                }
                else
                {
                    flightDictionary[flightArray[0]] += $",{flightArray[1]}";
                }
            }
            return flightDictionary;
        }

        public static void DisplayDestinations()
        {
            foreach (var element in flightDictionary)
            {
                Console.WriteLine("Departure: " + element.Key + ". Destination: " + element.Value);
            }
        }

        public static void DisplayDepartures()
        {
            foreach (var element in flightDictionary)
            {
                Console.WriteLine("Departure:" + element.Key);
            }
        }
    }
}

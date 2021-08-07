using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string Path = "../../flights.txt";
            string[] flights = File.ReadAllLines(Path);
            var flightDictionary = ConvertPathToDictionary(flights);
            List<string> flightCities = new List<string>();

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");
            var answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.WriteLine(DisplayDestinations(flightDictionary));
            }
            else return;
            
            Console.WriteLine("\nTo select a city from which you would like to start press 1");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.WriteLine(DisplayDepartures(flightDictionary));
            } 
            else return;

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

        public static Dictionary<string, string> ConvertPathToDictionary(string[] flights)
        {
            Dictionary<string, string> flightDictionary = new Dictionary<string, string>();
            
            string[] stringSeparators = { "->" };

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

        public static string DisplayDestinations(Dictionary<string, string> flightDictionary)
        {
            string destinations = "";
            foreach (var element in flightDictionary)
            {
                destinations += "Departure: " + element.Key + ". Destination: " + element.Value+"\n";
            }

            return destinations;
        }

        public static string DisplayDepartures(Dictionary<string, string> flightDictionary)
        {
            string departures = "";
            foreach (var element in flightDictionary)
            {
                departures += "Departure: " + element.Key+".\n";
            }

            return departures;
        }
    }
}

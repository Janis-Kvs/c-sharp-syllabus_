using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightPlanner.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ConvertPathToDictionary_3Flights_2Departures3DestinationsExpected()
        {
            //Arrange
            string[] flights = {"Riga -> Liepaja", "Liepaja -> Ventspils", "Riga -> Daugavpils"};
            //Act
            var expected = new Dictionary<string, string>()
            {
                {"Riga", "Liepaja,Daugavpils"},
                {"Liepaja", "Ventspils"}
            };
            var actual = Program.ConvertPathToDictionary(flights);
            //Assert
            Assert.IsTrue(actual.All(e => expected.Contains(e)));
        }

        [TestMethod]
        public void DisplayDepartures_RigaLiepajaDepartures_RigaLiepajaDeparturesExpected()
        {
            //Arrange
            var dictionary = new Dictionary<string, string>()
            {
                {"Riga", "Liepaja,Daugavpils"},
                {"Liepaja", "Ventspils"}
            };
            //Act
            var expected = "Departure: Riga.\n" +
                           "Departure: Liepaja.\n";
            var actual = Program.DisplayDepartures(dictionary);
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void DisplayDestination_3Flights_2Departures3DestinationsExpected()
        {
            //Arrange
            var dictionary = new Dictionary<string, string>()
            {
                {"Riga", "Liepaja,Daugavpils"},
                {"Liepaja", "Ventspils"}
            };
            //Act
            var expected = "Departure: Riga. Destination: Liepaja,Daugavpils\n" +
                           "Departure: Liepaja. Destination: Ventspils\n";
            var actual = Program.DisplayDestinations(dictionary);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

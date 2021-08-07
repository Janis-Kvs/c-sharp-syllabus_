using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneBook.Tests
{
    [TestClass]
    public class PhoneDirectoryTests
    {
        [TestMethod]
        public void GetNumber_NamePeteris_Number21235462Expected()
        {
            //Arrange
            PhoneDirectory phoneDirectory = new PhoneDirectory();
            phoneDirectory.PutNumber("Janis", "26590735");
            phoneDirectory.PutNumber("Evija", "24561238");
            phoneDirectory.PutNumber("Peteris", "21235462");
            phoneDirectory.PutNumber("Karlis", "26545435");
            phoneDirectory.PutNumber("Zane", "22246555");
            //Act
            var expected = 21235462;
            var actual = phoneDirectory.GetNumber("Peteris");
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void GetNumber_NameEmpty_NumberNullExpected()
        {
            //Arrange
            PhoneDirectory phoneDirectory = new PhoneDirectory();
            phoneDirectory.PutNumber("Janis", "26590735");
            phoneDirectory.PutNumber("Evija", "24561238");
            phoneDirectory.PutNumber("Peteris", "21235462");
            phoneDirectory.PutNumber("Karlis", "26545435");
            phoneDirectory.PutNumber("Zane", "22246555");
            //Act
            int? expected = null;
            var actual = phoneDirectory.GetNumber("");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListNumbers_3Entries_Sorted3EntriesExpected()
        {
            //Arrange
            PhoneDirectory phoneDirectory = new PhoneDirectory();
            phoneDirectory.PutNumber("Janis", "26590735");
            phoneDirectory.PutNumber("Evija", "24561238");
            phoneDirectory.PutNumber("Peteris", "21235462");
            //Act
            var expected = "Name: Evija, Phone number: 24561238\n" +
                           "Name: Janis, Phone number: 26590735\n" +
                           "Name: Peteris, Phone number: 21235462\n";
            var actual = phoneDirectory.ListNumbers();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PutNumber_Janis26590735_Janis26590735Expected()
        {
            //Arrange
            PhoneDirectory phoneDirectory = new PhoneDirectory();
            //Act
            var expected = "Name: Janis, Phone number: 26590735\n";
            phoneDirectory.PutNumber("Janis", "26590735");
            var actual = phoneDirectory.ListNumbers();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

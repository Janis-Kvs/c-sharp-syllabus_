using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using NUnit.Framework.Internal.Execution;

namespace Exercise6.Tests
{
    public class Tests
    {
        readonly int[] array1 = { 1, 2, 4, 3, 2, 1, 5, 7, 8, 10 };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CopyArray_Array1_Array3Expected()
        {
            //Act
            var actual = Program.CopyArray(array1);
            int[] expected = { 1, 2, 4, 3, 2, 1, 5, 7, 8, 10 };
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ChangeLast_Array1_Array3Expected()
        {
            //Act
            var actual = Program.ChangeLast(array1);
            int[] expected = { 1, 2, 4, 3, 2, 1, 5, 7, 8, -7 };
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
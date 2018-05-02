using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanLib;
using RomanLib.Exceptions;

namespace RomanLibTests
{
    [TestClass]
    public class BasicRomanNumberTests
    {
        private void TestConversion(string romanDigit, int expectedValue)
        {
            var result = RomanConverter.Convert(romanDigit);            
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Convert_I()
        {
            TestConversion("I", 1);
        }

        [TestMethod]
        public void Convert_i()
        {
            TestConversion("i", 1);
        }

        [TestMethod]
        public void Convert_V()
        {
            TestConversion("V", 5);
        }

        [TestMethod]
        public void Convert_v()
        {
            TestConversion("v", 5);
        }

        [TestMethod]
        public void Convert_X()
        {
            TestConversion("X", 10);
        }

        [TestMethod]
        public void Convert_x()
        {
            TestConversion("x", 10);
        }

        [TestMethod]
        public void Convert_L()
        {
            TestConversion("L", 50);
        }

        [TestMethod]
        public void Convert_l()
        {
            TestConversion("l", 50);
        }

        [TestMethod]
        public void Convert_C()
        {
            TestConversion("C", 100);
        }

        [TestMethod]
        public void Convert_c()
        {
            TestConversion("c", 100);
        }

        [TestMethod]
        public void Convert_D()
        {
            TestConversion("D", 500);
        }

        [TestMethod]
        public void Convert_d()
        {
            TestConversion("d", 500);
        }

        [TestMethod]
        public void Convert_M()
        {
            TestConversion("M", 1000);
        }

        [TestMethod]
        public void Convert_m()
        {
            TestConversion("m", 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(NoRomanDigitDefinedException))]
        public void ConvertNullDigitNumber()
        {
            TestConversion(null, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(NoRomanDigitDefinedException))]
        public void ConvertEmptyDigitNumber()
        {
            TestConversion(" ", 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanDigitException))]
        public void ConvertBadDigitNumber()
        {
            TestConversion("S", 30);            
        }
    }
}

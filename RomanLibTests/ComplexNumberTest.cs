using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanLib;

namespace RomanLibTests
{
    [TestClass]
    public class ComplexNumberTest
    {
        private void AssertRomanNumber(string romanNumber, int expected)
        {
            var result = RomanConverter.Convert(romanNumber);
            if( result != expected)
                Assert.Fail("Le chiffre " + romanNumber + " donne " + result.ToString(CultureInfo.InvariantCulture)+". attendu : "+expected);
        }

        [TestMethod]
        public void ConvertSomeComplexNumbers()
        {
            AssertRomanNumber("XIV", 14);
            AssertRomanNumber("DIX", 509);
        }
    }
}

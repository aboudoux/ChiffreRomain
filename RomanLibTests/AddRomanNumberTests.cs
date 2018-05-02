using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanLib;
using RomanLib.Exceptions;

namespace RomanLibTests
{
    [TestClass]
    public class AddRomanNumberTests
    {
        [TestMethod]
        public void TestAll_I()
        {
            Assert.AreEqual(RomanConverter.Convert("II"),2);
            Assert.AreEqual(RomanConverter.Convert("III"), 3);
        }

        [TestMethod]
        public void TestAll_X()
        {
            Assert.AreEqual(RomanConverter.Convert("XX"), 20);
            Assert.AreEqual(RomanConverter.Convert("XXX"), 30);
        }

        [TestMethod]
        public void TestAll_C()
        {
            Assert.AreEqual(RomanConverter.Convert("CC"), 200);
            Assert.AreEqual(RomanConverter.Convert("CCC"), 300);
        }

        [TestMethod]
        public void TestAll_M()
        {
            Assert.AreEqual(RomanConverter.Convert("MM"), 2000);
            Assert.AreEqual(RomanConverter.Convert("MMM"), 3000);
            Assert.AreEqual(RomanConverter.Convert("MMMM"), 4000);
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberFormatException))]
        public void CannotAddV()
        {
            RomanConverter.Convert("VV");
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberFormatException))]
        public void CannotAddL()
        {
            RomanConverter.Convert("LL");
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberFormatException))]
        public void CannotAddD()
        {
            RomanConverter.Convert("DD");
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberFormatException))]
        public void CannotAdd4X()
        {
            RomanConverter.Convert("XXXX");
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberFormatException))]
        public void CannotAdd4C()
        {
            RomanConverter.Convert("CCCC");
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberFormatException))]
        public void CannotAdd4I()
        {
            RomanConverter.Convert("IIII");
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberFormatException))]
        public void CannotAdd5M()
        {
            RomanConverter.Convert("MMMMM");
        }

        [TestMethod]
        public void Test()
        {
            var result = RomanConverter.Convert("CD");
            Assert.AreEqual(400, result);
        }
    }
}

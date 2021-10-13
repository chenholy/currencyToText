using NUnit.Framework;
using UnLeashPorject.Controllers;

namespace DollarsConverterTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, "One")]
        [TestCase(2, "Two")]
        [TestCase(0, "")]
        public void TestSingleDigit(int input, string expected)
        {
            Assert.AreEqual(Helpers.singleDigit(input), expected);
        }

        [TestCase(10, "Ten")]
        [TestCase(21, "Twenty One")]
        public void TestDoubleDigit(int input, string expected)
        {
            Assert.AreEqual(Helpers.doubleDigit(input), expected);
        }

        [TestCase(1000, 4, "One Thousand")]
        [TestCase(1000000, 7, "One Million")]
        [TestCase(1000000000, 10, "One Billion")]
        public void TestConvertDollarToString(int num, int numLength, string expected)
        {
            Assert.AreEqual(Helpers.convertDollarString(num, numLength), expected);
        }
    }
}
using System;
using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class AcrccosxCalculatorTest
    {
        [TestCase(1, 0)]
        [TestCase(0, 1.5707)]
        [TestCase(0.5, 1.0471)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArccosxCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);
        }

        [Test]
        public void ExceptionByRangeTest()
        {
            var calculator = new ArccosxCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-2));

        }
    }
}
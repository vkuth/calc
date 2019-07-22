using System;
using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class OneOnXCalculatorTest
    {
        [TestCase(1, 1)]
        [TestCase(3, 0.3333)]
        [TestCase(-7, -0.1428)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new OneOnXCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);
        }

        [Test]
        public void DevizionByZeroTest()
        {
            IOneArgumentCalculator calculator = new OneOnXCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(0));

        }
    }
}
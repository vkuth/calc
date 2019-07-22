using System;
using calculator.TwoArgumentCalculator;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculator
{
    [TestFixture]
    public class LogxyCalculatorTest
    {
        [TestCase(2, 1, 0)]
        [TestCase(3, 4, 1.2618)]
        [TestCase(7, 2,0.3562 )]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new LogxyCalculator();
            var result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result,0.0001);
        }

        [Test]
        public void ExceptionByNegativValueTest()
        {
            var calculator = new LogxyCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(2,-1));
        }

        [Test]
        public void ExceptionByBaseValueTest()
        {
            var calculator = new LogxyCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(1, 5));
        }
    }
}
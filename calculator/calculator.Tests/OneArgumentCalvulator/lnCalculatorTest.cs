using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class lnCalculatorTest
    {
        [TestCase(1, 0)]
        [TestCase(3, 1.0986)]
        [TestCase(7, 1.9459)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new lncalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);
        }

    }
}
using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class Log2CalculatorTest
    {
        [TestCase(1, 0)]
        [TestCase(3, 1.5849)]
        [TestCase(7, 2.8073)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new log2Calculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
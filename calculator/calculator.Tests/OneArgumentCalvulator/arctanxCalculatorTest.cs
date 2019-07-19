using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class arctanxCalculatorTest
    {
        [TestCase(1, 0.7853)]
        [TestCase(3, 1.2490)]
        [TestCase(-7, -1.4288)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new arctanxCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
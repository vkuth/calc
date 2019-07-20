using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class AntiCalculatorTest
    {
        [TestCase(1, -1)]
        [TestCase(3, -3)]
        [TestCase(-7, 7)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new AntiCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
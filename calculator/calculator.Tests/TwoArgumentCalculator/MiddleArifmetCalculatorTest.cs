using calculator.TwoArgumentCalculator;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculator
{
    [TestFixture]
    public class MiddleArifmetCalculatorTest
    {
        [TestCase(2, 1, 1.5)]
        [TestCase(3, 4, 3.5)]
        [TestCase(-7, -2, -4.5)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MiddleArifmetCalculator();
            var result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
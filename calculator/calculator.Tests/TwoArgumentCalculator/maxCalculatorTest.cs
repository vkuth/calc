using calculator.TwoArgumentCalculator;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculator
{
    [TestFixture]
    public class MaxCalculatorTest
    {
        [TestCase(0, 1, 1)]
        [TestCase(3, 4, 4)]
        [TestCase(-7, -2, -2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new maxCalculator();
            var result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}
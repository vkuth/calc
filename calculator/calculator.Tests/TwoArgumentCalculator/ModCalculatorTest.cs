using calculator.TwoArgumentCalculator;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculator
{
    [TestFixture]
    public class ModCalculatorTest
    {
        [TestCase(0, 1, 0)]
        [TestCase(3, 4, 3)]
        [TestCase(-7, -2, -1)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new ModCalculator();
            var result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}
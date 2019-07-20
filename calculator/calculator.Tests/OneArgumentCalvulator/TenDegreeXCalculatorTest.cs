using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class TenDegreeXCalculatorTest
    {
        [TestCase(1, 10)]
        [TestCase(3, 1000)]
        [TestCase(-2, 0.01)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new TenDegreeXCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
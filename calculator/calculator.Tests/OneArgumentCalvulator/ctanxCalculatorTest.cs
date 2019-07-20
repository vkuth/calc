using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class CtanxCalculatorTest
    {
        [TestCase(1, 0.6420)]
        [TestCase(3, -7.0152)]
        [TestCase(-7, -1.1475)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ctanxCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class TwoDegreeXCalculatorTest
    {
        [TestCase(1, 2)]
        [TestCase(3, 8)]
        [TestCase(-7, 0.0078)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new TwoDegreeXCalcularor();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
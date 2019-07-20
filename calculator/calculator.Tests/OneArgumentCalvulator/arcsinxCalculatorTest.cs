using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class ArcsinxCalculatorTest
    {
        [TestCase(1, 1.5707)]
        [TestCase(0, 0)]
        [TestCase(0.5, 0.5235)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new arcsinxCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
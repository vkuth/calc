using calculator.TwoArgumentCalculator;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculator
{
    [TestFixture]
    public class FractionalDegreeCalculatorTest
    {
        [TestCase(1, 1, 1)]
        [TestCase(3, 4, 1.3160)]
        [TestCase(7, 2,2.6457)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new FractionalDegreeCalculator();
            var result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class ExpCalculatorTest
    {
        [TestCase(0, 1)]
        [TestCase(3, 20.0855)]
        [TestCase(-7, 0.0009)]
        public void CalculateTest(double firstValue,double expected)
        {
            var calculator = new ExpcalCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result,0.0001);
        }

    }
}
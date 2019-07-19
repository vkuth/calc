using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class log10CalculatorTest
    {
        [TestCase(1, 0)]
        [TestCase(3, 0.4771)]
        [TestCase(7, 0.8450)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new log10calculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
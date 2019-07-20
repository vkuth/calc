using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class TANCalculatorTest
    {
        [TestCase(1, 1.5574)]
        [TestCase(3, -0.1425)]
        [TestCase(7, 0.8714)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new TANCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
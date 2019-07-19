using calculator.TwoArgumentCalculator;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculator
{
    [TestFixture]
    public class xonyCalculatorTest
    {
        [TestCase(0, 0, 1)]
        [TestCase(3, 4, 81)]
        [TestCase(-7, -2, 0.0204)]
        public void CalculateTest(double firstValue,double secondValue,double expected)
        {
            var calculator = new xonyCalculator();
            var result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result,0.0001);
        }

    }
}
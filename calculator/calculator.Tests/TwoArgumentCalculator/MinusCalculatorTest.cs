using calculator.TwoArgumentCalculator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class MinusCalculatorTest
    {
        [Test]
        public void CalculationTest()
        {
            ICalculator calculator = new MinusCalculator();
            double result = calculator.Calculate(2, 1);
            Assert.AreEqual(1, result);
        }

    }
}
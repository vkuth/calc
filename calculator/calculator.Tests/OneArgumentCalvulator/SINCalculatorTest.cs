using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class SINCalculatorTest
    {
        [Test]
        public void CalculationTest()
        {
            IOneArgumentCalculator calculator = new SINCalculator();
            double result = calculator.Calculate(45);
            Assert.AreEqual(0.8509, result, 0.0001);
        }
    }
}
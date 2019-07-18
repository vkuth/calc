using calculator.OneArgumentCalvulator;
using calculator.TwoArgumentCalculator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class COSCalculatorTest
    {
        [Test]
        public void CalculationTest()
        {
            IOneArgumentCalculator calculator = new COSCalculator();
            double result = calculator.Calculate(45);
            Assert.AreEqual(0.5253, result,0.0001);
        }
    }
}
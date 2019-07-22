using calculator.TwoArgumentCalculator;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculator
{
    [TestFixture]
    class MultipliCalculatorTest
    {
        [Test]
        public void CalculationTest()
        {
            ICalculator calculator = new MultipliCalculator();
            double result = calculator.Calculate(2, 1);
            Assert.AreEqual(2, result);
        }
    }
}

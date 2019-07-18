using calculator.TwoArgumentCalculator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class PlusCalculatorTests
    {
        [Test]
        public void CalculationTest()
        {
            ICalculator calculator = new PlusCalculator();
            double result = calculator.Calculate(1, 2);
            Assert.AreEqual(3, result);
        }


    }
}
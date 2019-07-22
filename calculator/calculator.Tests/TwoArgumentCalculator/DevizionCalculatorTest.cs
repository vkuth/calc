using System;
using calculator.TwoArgumentCalculator;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculator
{
    [TestFixture]
    public class DevizionCalculatorTest
    {
        [Test]
        public void CalculationTest()
        {
            ICalculator calculator = new DivizionCalculator();
            double result = calculator.Calculate(6, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void DevizionByZeroTest()
        {
            ICalculator calculator = new DivizionCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(6, 0));

        }
    }
}
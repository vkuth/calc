using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ICalculator calculator = new multiplicalculator();
            double result = calculator.Calculate(2, 1);
            Assert.AreEqual(2, result);
        }
    }
}

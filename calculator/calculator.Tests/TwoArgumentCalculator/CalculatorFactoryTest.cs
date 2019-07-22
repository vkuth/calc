using System;
using calculator.TwoArgumentCalculator;
using NUnit.Framework;

namespace calculator.Tests.CalculatorFactoryTest
{
    [TestFixture]
    public class CalculatorFactoryTest
    {
        [TestCase("plus", typeof(PlusCalculator))]
        [TestCase("minus", typeof(MinusCalculator))]
        [TestCase("multipli", typeof(MultipliCalculator))]
        [TestCase("divizion", typeof(DivizionCalculator))]
        [TestCase("frdegree", typeof(FractionalDegreeCalculator))]
        [TestCase("logxy", typeof(LogxyCalculator))]
        [TestCase("max", typeof(MaxCalculator))]
        [TestCase("arif", typeof(MiddleArifmetCalculator))]
        [TestCase("mod", typeof(ModCalculator))]
        [TestCase("xony", typeof(XOnYCalculator))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = CalculatorFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
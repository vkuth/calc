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
        [TestCase("multipli", typeof(multiplicalculator))]
        [TestCase("divizion", typeof(divizioncalculator))]
        [TestCase("frdegree", typeof(FractionalDegreeCalculator))]
        [TestCase("logxy", typeof(logxyCalculator))]
        [TestCase("max", typeof(maxCalculator))]
        [TestCase("arif", typeof(MiddleArifmetCalculator))]
        [TestCase("mod", typeof(ModCalculator))]
        [TestCase("xony", typeof(xonyCalculator))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = CalculatorFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
using System;
using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculatorFactoryTest
{
    [TestFixture]
    public class OneArgumentCalculatorFactoryTest
    {
        [TestCase("sin", typeof(SINCalculator))]
        [TestCase("cos", typeof(COSCalculator))]
        [TestCase("log2", typeof(Log2Calculator))]
        [TestCase("tan", typeof(TANCalculator))]
        [TestCase("modul", typeof(ModulCalculator))]
        [TestCase("anti", typeof(AntiCalculator))]
        [TestCase("twox", typeof(TwoDegreeXCalcularor))]
        [TestCase("tenx", typeof(TenDegreeXCalculator))]
        [TestCase("exp", typeof(ExpcalCalculator))]
        [TestCase("ln", typeof(LnCalculator))]
        [TestCase("log10", typeof(Log10Calculator))]
        [TestCase("oneonx", typeof(OneOnXCalculator))]
        [TestCase("arctanx", typeof(ArctanxCalculator))]
        [TestCase("arccosx", typeof(ArccosxCalculator))]
        [TestCase("arcsinx", typeof(ArcsinxCalculator))]
        [TestCase("ctanx", typeof(CtanxCalculator))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentCalculatorFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}
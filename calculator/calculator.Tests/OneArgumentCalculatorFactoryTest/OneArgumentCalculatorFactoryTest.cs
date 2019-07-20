﻿using System;
using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculatorFactoryTest
{
    [TestFixture]
    public class OneArgumentCalculatorFactoryTest
    {
        [TestCase("sin", typeof(SINCalculator))]
        [TestCase("cos", typeof(COSCalculator))]
        [TestCase("log2", typeof(log2Calculator))]
        [TestCase("tan", typeof(TANCalculator))]
        [TestCase("modul", typeof(ModulCalculator))]
        [TestCase("anti", typeof(AntiCalculator))]
        [TestCase("twox", typeof(TwoDegreeXCalcularor))]
        [TestCase("tenx", typeof(TenDegreeXCalculator))]
        [TestCase("exp", typeof(expcalculator))]
        [TestCase("ln", typeof(lncalculator))]
        [TestCase("log10", typeof(log10calculator))]
        [TestCase("oneonx", typeof(oneonxCalculator))]
        [TestCase("arctanx", typeof(arctanxCalculator))]
        [TestCase("arccosx", typeof(arccosxCalculator))]
        [TestCase("arcsinx", typeof(arcsinxCalculator))]
        [TestCase("ctanx", typeof(ctanxCalculator))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentCalculatorFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}
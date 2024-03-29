﻿using System;
using calculator.OneArgumentCalvulator;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalvulator
{
    [TestFixture]
    public class Log10CalculatorTest
    {
        [TestCase(1, 0)]
        [TestCase(3, 0.4771)]
        [TestCase(7, 0.8450)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Log10Calculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);
        }
        [Test]
        public void ExceptionByNegativValueTest()
        {
            var calculator = new Log10Calculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-1));

        }
    }
}
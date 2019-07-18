﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class MinusCalculator : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}

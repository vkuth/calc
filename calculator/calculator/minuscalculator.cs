﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class minuscalculator : ICalculator
    {
        public double Calculate(double firstvalue, double secondvalue)
        {
            return firstvalue - secondvalue;
        }
    }
}

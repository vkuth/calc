﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public static class CalculatorFactory
    {
        public static ICalculator CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "plus":
                    return new pluscalculator();
                case "minus":
                    return new MinusCalculator();
                case "multipli":
                    return new multiplicalculator();
                case "divizion":
                    return new divizioncalculator();
                default: throw new Exception("Huston we have a problem");
            }
        }
    }
}

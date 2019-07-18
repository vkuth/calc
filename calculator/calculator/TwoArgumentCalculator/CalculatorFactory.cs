﻿using System;

namespace calculator.TwoArgumentCalculator
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
                case "mod":
                    return new ModCalculator();
                case "logxy":
                    return new logxyCalculator();
                case "frdegree":
                    return new FractionalDegreeCalculator();
                case "arif":
                    return new MiddleArifmetCalculator();
                default: throw new Exception("Huston we have a problem");
            }
        }
    }
}
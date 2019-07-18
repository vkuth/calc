﻿using System;

namespace calculator.OneArgumentCalvulator
{
    public static class OneArgumentCalculatorFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "sin":
                    return new SINCalculator();
                case "cos":
                    return new COSCalculator();
                case "log2":
                    return new log2Calculator();
                case "tan":
                    return new TANCalculator();
                case "modul":
                    return new ModulCalculator();
                case "anti":
                    return new AntiCalculator();
                case "twox":
                    return new TwoDegreeXCalcularor();
                case "tenx":
                    return new TenDegreeXCalculator();
                case "exp":
                    return new expcalculator();
                case "ln":
                    return new lncalculator();
                default: throw new Exception("Huston we have a problem");
            }
        }
    }
}

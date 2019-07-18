using System;

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
                default: throw new Exception("Huston we have a problem");
            }
        }
    }
}

using System;

namespace calculator.TwoArgumentCalculator
{
    public static class CalculatorFactory
    {
        /// <summary>
        /// This method performs the appropriate action depending on the transferred name
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        public static ICalculator CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "plus":
                    return new PlusCalculator();
                case "minus":
                    return new MinusCalculator();
                case "multipli":
                    return new MultipliCalculator();
                case "divizion":
                    return new DivizionCalculator();
                case "mod":
                    return new ModCalculator();
                case "logxy":
                    return new LogxyCalculator();
                case "frdegree":
                    return new FractionalDegreeCalculator();
                case "arif":
                    return new MiddleArifmetCalculator();
                case "xony":
                    return new XOnYCalculator();
                case "max":
                    return new MaxCalculator();
                default: throw new Exception("Huston we have a problem");
            }
        }
    }
}

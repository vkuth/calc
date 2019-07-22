using System;

namespace calculator.OneArgumentCalvulator
{
    public static class OneArgumentCalculatorFactory
    {
        /// <summary>
        /// This method performs the appropriate action depending on the transferred name
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        public static IOneArgumentCalculator CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "sin":
                    return new SINCalculator();
                case "cos":
                    return new COSCalculator();
                case "log2":
                    return new Log2Calculator();
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
                    return new ExpcalCalculator();
                case "ln":
                    return new LnCalculator();
                case "log10":
                    return new Log10Calculator();
                case "oneonx":
                    return new OneOnXCalculator();
                case "arctanx":
                    return new ArctanxCalculator();
                case "arccosx":
                    return new ArccosxCalculator();
                case "arcsinx":
                    return new ArcsinxCalculator();
                case "ctanx":
                    return new CtanxCalculator();
                default: throw new Exception("Huston we have a problem");
            }
        }
    }
}

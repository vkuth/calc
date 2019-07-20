using System;

namespace calculator.OneArgumentCalvulator
{
    public static class OneArgumentCalculatorFactory
    {/// <summary>
     /// Этот метод выполняет соответсвуюшее действие в зависимости от нажатой кнопки.
     /// </summary>
     /// <param name="operation">Принимает условие</param>
     /// <returns>Выполнение действия</returns>
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
                case "log10":
                    return new log10calculator();
                case "oneonx":
                    return new oneonxCalculator();
                case "arctanx":
                    return new arctanxCalculator();
                case "arccosx":
                    return new arccosxCalculator();
                case "arcsinx":
                    return new arcsinxCalculator();
                case "ctanx":
                    return new ctanxCalculator();
                default: throw new Exception("Huston we have a problem");
            }
        }
    }
}

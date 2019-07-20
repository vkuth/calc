using System;

namespace calculator.OneArgumentCalvulator
{
    public class COSCalculator:IOneArgumentCalculator
    {/// <summary>
     /// Вычисление косинуса заданого числа
     /// </summary>
     /// <param name="firstValue">Заданное число</param>
     /// <returns>Результат косинуса</returns>
        public double Calculate(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}

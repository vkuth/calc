using System;

namespace calculator.OneArgumentCalvulator
{
    public class SINCalculator: IOneArgumentCalculator
    {/// <summary>
     /// Вычисление синуса заданого числа
     /// </summary>
     /// <param name="firstValue">Заданное число</param>
     /// <returns>Результат синуса</returns>
        public double Calculate(double firstValue)
        {
            return Math.Sin(firstValue);
        }
        
    }
}

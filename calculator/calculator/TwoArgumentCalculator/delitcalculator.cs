using System;

namespace calculator.TwoArgumentCalculator
{
   
    public class divizioncalculator : ICalculator
    {/// <summary>
    /// Выполнение действия деления двух чисел
    /// </summary>
    /// <param name="firstvalue">Первое число</param>
    /// <param name="secondvalue">Второе число</param>
    /// <returns>Результат деления</returns>
        public double Calculate(double firstvalue, double secondvalue)
        {
            if (secondvalue == 0)
            {
                throw new Exception("Деление на 0");
            }

            return firstvalue / secondvalue;
        }
    }
}

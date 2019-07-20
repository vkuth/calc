using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    public class oneonxCalculator : IOneArgumentCalculator
    {/// <summary>
    /// Деление единицы на заданое число
    /// </summary>
    /// <param name="firstValue">Заданое число</param>
    /// <returns>Результат деления</returns>
        public double Calculate(double firstValue)
        {
            if (firstValue == 0)
            {
                throw new Exception("Деление на 0");
            }
            return 1/(firstValue);
        }
    }
}

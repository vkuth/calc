using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    public class expcalculator : IOneArgumentCalculator
    {/// <summary>
     /// Возведение экспоненты в степень заданного числа
     /// </summary>
     /// <param name="firstValue">Заданное число</param>
     /// <returns>Результат возведения</returns>
        public double Calculate(double firstValue)
        {
            return Math.Exp(firstValue);
        }
    }
}

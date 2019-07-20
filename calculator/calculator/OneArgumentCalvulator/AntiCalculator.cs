using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    public class AntiCalculator : IOneArgumentCalculator
    {/// <summary>
     /// Изменение знака заданого числа
     /// </summary>
     /// <param name="firstValue">Заданное число</param>
     /// <returns>Заданное число с обратным знаком</returns>
        public double Calculate(double firstValue)
        {
           return firstValue - (2 * firstValue);
        }

    }
}

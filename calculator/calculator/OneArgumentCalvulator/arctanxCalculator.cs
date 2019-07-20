using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    public class arctanxCalculator : IOneArgumentCalculator
    {/// <summary>
     /// Вычисление арктангенса заданого числа
     /// </summary>
     /// <param name="firstValue">Заданное число</param>
     /// <returns>Результат арктангенса</returns>
        public double Calculate(double firstValue)
        {
            return Math.Atan(firstValue);
        }
    }
}

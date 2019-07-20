using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    public class TANCalculator : IOneArgumentCalculator
    {/// <summary>
     /// Вычисление тангенса заданого числа
     /// </summary>
     /// <param name="firstValue">Заданное число</param>
     /// <returns>Результат тангенса</returns>
        public double Calculate(double firstValue)
        {
            return Math.Tan(firstValue);
        }
    }
}

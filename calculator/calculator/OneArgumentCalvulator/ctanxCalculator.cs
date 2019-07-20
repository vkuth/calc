using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    public class ctanxCalculator : IOneArgumentCalculator
    {/// <summary>
     /// Вычисление котангенса заданого числа
     /// </summary>
     /// <param name="firstValue">Заданное число</param>
     /// <returns>Результат котангенса</returns>
        public double Calculate(double firstValue)
        {
            return 1/Math.Tan(firstValue);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    public class TwoDegreeXCalcularor : IOneArgumentCalculator
    {/// <summary>
     /// Возведение 2 в степень заданого числа
     /// </summary>
     /// <param name="firstValue">Заданное число</param>
     /// <returns>Результат возведения</returns>
        public double Calculate(double firstValue)
        {
            return Math.Pow(2, firstValue);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    public class ModulCalculator : IOneArgumentCalculator
    {/// <summary>
     /// Вывод модуля заданного числа
     /// </summary>
     /// <param name="firstValue">Заданное число</param>
     /// <returns>Модуль числа</returns>
        public double Calculate(double firstValue)
        {
            return Math.Abs(firstValue);
        }

    }
}

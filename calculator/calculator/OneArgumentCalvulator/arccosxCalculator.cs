using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    public class arccosxCalculator : IOneArgumentCalculator
    {/// <summary>
     /// Вычисление арккосинуса заданого числа
     /// </summary>
     /// <param name="firstValue">Заданное число</param>
     /// <returns>Результат арккосинуса</returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < -1 || firstValue>1)
            {
                throw new Exception("Вне диапазона");
            }
            return Math.Acos(firstValue);
        }
    }
}

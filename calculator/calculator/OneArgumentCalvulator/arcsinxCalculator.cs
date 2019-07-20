using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    public class arcsinxCalculator : IOneArgumentCalculator
    {/// <summary>
     /// Вычисление арксинуса заданого числа
     /// </summary>
     /// <param name="firstValue">Заданное число</param>
     /// <returns>Результат арксинуса</returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < -1 || firstValue > 1)
            {
                throw new Exception("Вне диапазона");
            }
            return Math.Asin(firstValue);
        }
    }
}

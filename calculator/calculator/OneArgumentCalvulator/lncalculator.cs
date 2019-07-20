using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    public class lncalculator : IOneArgumentCalculator
    {/// <summary>
     /// Вычисление натурального логарифма от заданого числа
     /// </summary>
     /// <param name="firstValue">Заданное число</param>
     /// <returns>Результат логарифма</returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < 0)
            {
                throw new Exception("Логарифм отрицательного числа");
            }
            return Math.Log(firstValue);
        }
    }
}
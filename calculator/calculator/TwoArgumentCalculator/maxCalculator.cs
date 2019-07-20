using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.TwoArgumentCalculator
{
    public class maxCalculator : ICalculator
    {/// <summary>
     /// Сравнение первого и второго числа на максимум
     /// </summary>
     /// <param name="firstvalue">Первое число</param>
     /// <param name="secondvalue">Второе число</param>
     /// <returns>Результат сравнения</returns>
        public double Calculate(double firstvalue, double secondvalue)
        {
            if (firstvalue > secondvalue)
            {
                return firstvalue;
            }
            else
            {
                return secondvalue;
            }
        }
    }
}

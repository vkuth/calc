using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.TwoArgumentCalculator
{
    public class MiddleArifmetCalculator : ICalculator
    {/// <summary>
     /// Вычисление среднего арифметического
     /// </summary>
     /// <param name="firstvalue">Первое число</param>
     /// <param name="secondvalue">Второе число</param>
     /// <returns>Результат вычисления</returns>
        public double Calculate(double firstvalue, double secondvalue)
        {
            return (firstvalue + secondvalue)/2;
        }
    }
}

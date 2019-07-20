using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.TwoArgumentCalculator
{
    public class FractionalDegreeCalculator : ICalculator
    {/// <summary>
    /// Возведение первого числа в дробную степень с знаменателем вторым числом
    /// </summary>
    /// <param name="firstValue">Первое число</param>
    /// <param name="secondValue">Второе число</param>
    /// <returns>Результат возведения</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue,(1/secondValue));
        }

    }
}

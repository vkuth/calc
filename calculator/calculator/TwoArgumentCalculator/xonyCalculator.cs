using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.TwoArgumentCalculator
{
    public class xonyCalculator : ICalculator
    {/// <summary>
    /// Возведение первого числа в степень второго числа
    /// </summary>
    /// <param name="firstvalue">Первое число</param>
    /// <param name="secondvalue">Второе число</param>
    /// <returns>Результат возведения</returns>
        public double Calculate(double firstvalue, double secondvalue)
        {
            return Math.Pow(firstvalue,secondvalue);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.TwoArgumentCalculator
{
    public class ModCalculator : ICalculator
    {/// <summary>
    /// Вычисление остатка от деления 
    /// </summary>
    /// <param name="firstValue">Первое число</param>
    /// <param name="secondValue">Второе число</param>
    /// <returns>Результат вычисления</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue % secondValue;
        }

    }
}

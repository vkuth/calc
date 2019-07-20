using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.TwoArgumentCalculator
{
    public class logxyCalculator : ICalculator
    {
        public double Calculate(double firstValue,double secondValue)
        {
            if (secondValue < 0)
            {
                throw new Exception("Логарифм отрицательного числа");
            }
            if (firstValue <= 1)
            {
                throw new Exception("Не допустимое основание");
            }
            return Math.Log(secondValue, firstValue);
        }

    }
}

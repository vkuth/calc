using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    public class oneonxCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if (firstValue == 0)
            {
                throw new Exception("Деление на 0");
            }
            return 1/(firstValue);
        }
    }
}

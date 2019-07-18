using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    class arccosxCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Acos(firstValue);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    class arcsinxCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Asin(firstValue);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    public class AntiCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
           return firstValue - (2 * firstValue);
        }

    }
}

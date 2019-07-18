using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    class log10calculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Log10(firstValue);
        }
    }
}

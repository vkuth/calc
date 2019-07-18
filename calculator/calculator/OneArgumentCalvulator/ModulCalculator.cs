using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    class ModulCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Abs(firstValue);
        }

    }
}

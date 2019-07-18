using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalvulator
{
    class TwoDegreeXCalcularor : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(2, firstValue);
        }
    }
}

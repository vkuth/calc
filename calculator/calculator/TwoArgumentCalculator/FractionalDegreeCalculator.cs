using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.TwoArgumentCalculator
{
    class FractionalDegreeCalculator : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue,(1/secondValue));
        }

    }
}

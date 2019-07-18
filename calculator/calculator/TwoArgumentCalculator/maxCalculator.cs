using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.TwoArgumentCalculator
{
    class maxCalculator : ICalculator
    {
        public double Calculate(double firstvalue, double secondvalue)
        {
            if (firstvalue > secondvalue)
            {
                return firstvalue;
            }
            else
            {
                return secondvalue;
            }
        }
    }
}

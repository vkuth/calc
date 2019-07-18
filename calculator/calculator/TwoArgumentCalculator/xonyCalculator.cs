using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.TwoArgumentCalculator
{
    class xonyCalculator : ICalculator
    {
        public double Calculate(double firstvalue, double secondvalue)
        {
            return Math.Pow(firstvalue,secondvalue);
        }
    }
}

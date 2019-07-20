using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.TwoArgumentCalculator
{
    public class logxyCalculator : ICalculator
    {
        public double Calculate(double firstValue,double secondValue)
        {
            return Math.Log(secondValue, firstValue);
        }

    }
}

using System;

namespace calculator.OneArgumentCalvulator
{
    class COSCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}

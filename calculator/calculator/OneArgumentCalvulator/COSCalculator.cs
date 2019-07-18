using System;

namespace calculator.OneArgumentCalvulator
{
    public class COSCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}

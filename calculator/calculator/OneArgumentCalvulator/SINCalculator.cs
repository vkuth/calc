using System;

namespace calculator.OneArgumentCalvulator
{
    class SINCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Sin(firstValue);
        }
        
    }
}

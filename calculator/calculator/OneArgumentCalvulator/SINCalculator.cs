using System;

namespace calculator.OneArgumentCalvulator
{
    public class SINCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Sin(firstValue);
        }
        
    }
}

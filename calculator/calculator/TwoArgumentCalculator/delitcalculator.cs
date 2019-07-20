using System;

namespace calculator.TwoArgumentCalculator
{
   
    public class divizioncalculator : ICalculator
    {
        public double Calculate(double firstvalue, double secondvalue)
        {
            if (secondvalue == 0)
            {
                throw new Exception("Деление на 0");
            }

            return firstvalue / secondvalue;
        }
    }
}

﻿namespace calculator.TwoArgumentCalculator
{
    class MinusCalculator : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
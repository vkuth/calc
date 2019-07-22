using System;

namespace calculator.OneArgumentCalvulator
{
    public class LnCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate the natural log of a given number
        /// </summary>
        /// <param name="firstValue">Preset number</param>
        /// <returns>Logarithm result</returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < 0)
            {
                throw new Exception("Логарифм отрицательного числа");
            }
            return Math.Log(firstValue);
        }
    }
}
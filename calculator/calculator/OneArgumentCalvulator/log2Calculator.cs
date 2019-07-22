using System;

namespace calculator.OneArgumentCalvulator
{
    public class Log2Calculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate the binary logarithm of a given number
        /// </summary>
        /// <param name="firstValue">Preset number</param>
        /// <returns>Logarithm result</returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < 0)
            {
                throw new Exception("Логарифм отрицательного числа");
            }
            return Math.Log(firstValue, 2);
        }

    }
}

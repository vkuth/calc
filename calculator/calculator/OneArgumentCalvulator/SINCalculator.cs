using System;

namespace calculator.OneArgumentCalvulator
{
    public class SINCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculating the sine of a given number
        /// </summary>
        /// <param name="firstValue">Preset number</param>
        /// <returns>Sine result</returns>
        public double Calculate(double firstValue)
        {
            return Math.Sin(firstValue);
        }

    }
}

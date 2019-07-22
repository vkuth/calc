using System;

namespace calculator.OneArgumentCalvulator
{
    public class ExpcalCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Raising the exponent to the power of a given number
        /// </summary>
        /// <param name="firstValue">Preset number</param>
        /// <returns>The result of the construction</returns>
        public double Calculate(double firstValue)
        {
            return Math.Exp(firstValue);
        }
    }
}

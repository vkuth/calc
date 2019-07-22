using System;

namespace calculator.OneArgumentCalvulator
{
    public class TenDegreeXCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Raising 10 to the power of a given number
        /// </summary>
        /// <param name="firstValue">Preset number</param>
        /// <returns>The result of the construction</returns>
        public double Calculate(double firstValue)
        {
            return Math.Pow(10, firstValue);
        }
    }
}

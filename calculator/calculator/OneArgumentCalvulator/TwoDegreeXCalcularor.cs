using System;

namespace calculator.OneArgumentCalvulator
{
    public class TwoDegreeXCalcularor : IOneArgumentCalculator
    {
        /// <summary>
        /// Raising 2 to the power of a given number
        /// </summary>
        /// <param name="firstValue">Preset number</param>
        /// <returns>The result of the construction</returns>
        public double Calculate(double firstValue)
        {
            return Math.Pow(2, firstValue);
        }
    }
}

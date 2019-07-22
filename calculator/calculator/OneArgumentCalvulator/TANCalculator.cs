using System;

namespace calculator.OneArgumentCalvulator
{
    public class TANCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculating the tangent of a given number
        /// </summary>
        /// <param name="firstValue">Preset number</param>
        /// <returns>Tangent result</returns>
        public double Calculate(double firstValue)
        {
            return Math.Tan(firstValue);
        }
    }
}

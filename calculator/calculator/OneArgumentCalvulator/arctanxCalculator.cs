using System;

namespace calculator.OneArgumentCalvulator
{
    public class ArctanxCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate the arctangent of a given number
        /// </summary>
        /// <param name="firstValue">Preset number</param>
        /// <returns>Arctangent result</returns>
        public double Calculate(double firstValue)
        {
            return Math.Atan(firstValue);
        }
    }
}

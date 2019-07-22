using System;

namespace calculator.OneArgumentCalvulator
{
    public class CtanxCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculating the cotangent of a given number
        /// </summary>
        /// <param name="firstValue">Preset number</param>
        /// <returns>Result of cotangent</returns>
        public double Calculate(double firstValue)
        {
            return 1 / Math.Tan(firstValue);
        }
    }
}

using System;

namespace calculator.TwoArgumentCalculator
{
    public class FractionalDegreeCalculator : ICalculator
    {
        /// <summary>
        /// Raising the first number to a fractional degree with the second denominator
        /// </summary>
        /// <param name="firstValue">First number</param>
        /// <param name="secondValue">Second number</param>
        /// <returns>The result of the construction</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, (1 / secondValue));
        }

    }
}

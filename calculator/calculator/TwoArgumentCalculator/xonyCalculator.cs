using System;

namespace calculator.TwoArgumentCalculator
{
    public class XOnYCalculator : ICalculator
    {
        /// <summary>
        /// Raising the first number to the power of the second
        /// </summary>
        /// <param name="firstvalue">First number</param>
        /// <param name="secondvalue">Second number</param>
        /// <returns>The result of the construction</returns>
        public double Calculate(double firstvalue, double secondvalue)
        {
            return Math.Pow(firstvalue, secondvalue);
        }
    }
}

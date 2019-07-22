using System;

namespace calculator.OneArgumentCalvulator
{
    public class ModulCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Module output of a given number
        /// </summary>
        /// <param name="firstValue">Preset number</param>
        /// <returns>The absolute value of a number</returns>
        public double Calculate(double firstValue)
        {
            return Math.Abs(firstValue);
        }

    }
}

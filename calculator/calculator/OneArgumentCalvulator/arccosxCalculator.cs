using System;

namespace calculator.OneArgumentCalvulator
{
    public class ArccosxCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculation of arccos of a given number
        /// </summary>
        /// <param name="firstValue">Preset number</param>
        /// <returns>Arccos result</returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < -1 || firstValue > 1)
            {
                throw new Exception("Вне диапазона");
            }
            return Math.Acos(firstValue);
        }
    }
}

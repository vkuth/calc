using System;

namespace calculator.OneArgumentCalvulator
{
    public class ArcsinxCalculator : IOneArgumentCalculator
    {
        /// <summary>
        ///Calculate the arcsin of a given number
        /// </summary>
        /// <param name="firstValue">Preset number</param>
        /// <returns>Arcsin result</returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < -1 || firstValue > 1)
            {
                throw new Exception("Вне диапазона");
            }
            return Math.Asin(firstValue);
        }
    }
}

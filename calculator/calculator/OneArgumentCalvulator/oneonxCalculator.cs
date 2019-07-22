using System;

namespace calculator.OneArgumentCalvulator
{
    public class OneOnXCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Division of a unit by a given number
        /// </summary>
        /// <param name="firstValue">Preset number</param>
        /// <returns>Division result</returns>
        public double Calculate(double firstValue)
        {
            if (firstValue == 0)
            {
                throw new Exception("Деление на 0");
            }
            return 1 / (firstValue);
        }
    }
}

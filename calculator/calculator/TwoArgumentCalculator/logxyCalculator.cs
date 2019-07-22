using System;

namespace calculator.TwoArgumentCalculator
{
    public class LogxyCalculator : ICalculator
    {
        /// <summary>
        /// Calculation of the logarithm of the second number with the basis of the first number
        /// </summary>
        /// <param name="firstValue">First number</param>
        /// <param name="secondValue">Second number</param>
        /// <returns>The result of the calculation</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue < 0)
            {
                throw new Exception("Логарифм отрицательного числа");
            }
            if (firstValue <= 1)
            {
                throw new Exception("Не допустимое основание");
            }
            return Math.Log(secondValue, firstValue);
        }

    }
}

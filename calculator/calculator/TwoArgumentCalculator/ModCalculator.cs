namespace calculator.TwoArgumentCalculator
{
    public class ModCalculator : ICalculator
    {
        /// <summary>
        /// Calculation of the remainder of the division
        /// </summary>
        /// <param name="firstValue">First number</param>
        /// <param name="secondValue">Second number</param>
        /// <returns>The result of the calculation</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue % secondValue;
        }

    }
}

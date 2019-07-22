namespace calculator.TwoArgumentCalculator
{
    public class PlusCalculator : ICalculator
    {
        /// <summary>
        /// Calculate the sum of numbers
        /// </summary>
        /// <param name="firstValue">First number</param>
        /// <param name="secondValue">Second number</param>
        /// <returns>The result of the calculation</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}

namespace calculator.TwoArgumentCalculator
{
    public class MinusCalculator : ICalculator
    {
        /// <summary>
        /// Subtract the first number from the first
        /// </summary>
        /// <param name="firstValue">First number</param>
        /// <param name="secondValue">Second number</param>
        /// <returns>Subtraction result</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}

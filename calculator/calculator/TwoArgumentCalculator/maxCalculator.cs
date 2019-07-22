namespace calculator.TwoArgumentCalculator
{
    public class MaxCalculator : ICalculator
    {
        /// <summary>
        /// Comparing the first and second numbers to the maximum
        /// </summary>
        /// <param name="firstvalue">First number</param>
        /// <param name="secondvalue">Second number</param>
        /// <returns>Comparison result</returns>
        public double Calculate(double firstvalue, double secondvalue)
        {
            if (firstvalue > secondvalue)
            {
                return firstvalue;
            }
            else
            {
                return secondvalue;
            }
        }
    }
}

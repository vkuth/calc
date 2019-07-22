namespace calculator.OneArgumentCalvulator
{
    public class AntiCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Change the sign of a given number
        /// </summary>
        /// <param name="firstValue">Preset number</param>
        /// <returns>Given number with opposite sign</returns>
        public double Calculate(double firstValue)
        {
            return firstValue - (2 * firstValue);
        }

    }
}

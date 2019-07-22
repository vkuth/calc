namespace calculator.TwoArgumentCalculator
{
    public class MiddleArifmetCalculator : ICalculator
    {
        /// <summary>
        /// Вычисление среднего арифметического
        /// </summary>
        /// <param name="firstvalue">First number</param>
        /// <param name="secondvalue">Second number</param>
        /// <returns>The result of the calculation</returns>
        public double Calculate(double firstvalue, double secondvalue)
        {
            return (firstvalue + secondvalue) / 2;
        }
    }
}

using System;

namespace calculator.TwoArgumentCalculator
{

    public class DivizionCalculator : ICalculator
    {
        /// <summary>
        /// Perform the action of dividing two numbers
        /// </summary>
        /// <param name="firstvalue">First number</param>
        /// <param name="secondvalue">Second number</param>
        /// <returns>Division result</returns>
        public double Calculate(double firstvalue, double secondvalue)
        {
            if (secondvalue == 0)
            {
                throw new Exception("Деление на 0");
            }

            return firstvalue / secondvalue;
        }
    }
}

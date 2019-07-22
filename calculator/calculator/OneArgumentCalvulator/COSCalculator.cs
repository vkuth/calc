using System;

namespace calculator.OneArgumentCalvulator
{
    public class COSCalculator : IOneArgumentCalculator
    { /// <summary>
      /// Calculating the cosine of a given number
      /// </summary>
      /// <param name="firstValue">Preset number</param>
      /// <returns>Cosine result</returns>
        public double Calculate(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}

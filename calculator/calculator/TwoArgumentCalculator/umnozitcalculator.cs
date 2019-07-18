namespace calculator.TwoArgumentCalculator
{
    class multiplicalculator : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}

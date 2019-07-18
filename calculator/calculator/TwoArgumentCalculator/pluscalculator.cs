namespace calculator.TwoArgumentCalculator
{
    class pluscalculator:ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}

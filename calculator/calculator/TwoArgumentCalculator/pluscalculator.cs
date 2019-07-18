namespace calculator.TwoArgumentCalculator
{
    public class PlusCalculator:ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}

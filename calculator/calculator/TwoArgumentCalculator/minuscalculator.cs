namespace calculator.TwoArgumentCalculator
{
    public class MinusCalculator : ICalculator
    {/// <summary>
     /// Вычитание ворого числа из первого
     /// </summary>
     /// <param name="firstValue">Первое число</param>
     /// <param name="secondValue">Второе число</param>
     /// <returns>Результат вычетания</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}

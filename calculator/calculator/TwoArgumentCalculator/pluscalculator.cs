namespace calculator.TwoArgumentCalculator
{
    public class PlusCalculator:ICalculator
    {/// <summary>
    /// Вычиление суммы чисел
    /// </summary>
    /// <param name="firstValue">Первое число</param>
    /// <param name="secondValue">Второе число</param>
    /// <returns>Результат вычисления</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}

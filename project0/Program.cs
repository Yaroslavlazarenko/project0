internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new();
        float number1 = r.NextSingle() * 100 - 50, number2 = r.NextSingle() * 100 - 50;

        Console.WriteLine("Calculate: {0} number2<0?-:+ {1} = {2}", number1, number2, MultiplicationNumb(number1, number2));

    }

    /// <summary>
    /// Функция вычисления произведения двух вещественных чисел
    /// </summary>
    /// <param name="number1">Первый множитель</param>
    /// <param name="number2">Второй множитель</param>
    /// <returns>Произведение</returns>
    public static float MultiplicationNumb(float number1, float number2)
    {
        return number1 * number2;
    }
}
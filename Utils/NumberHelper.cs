namespace Utils;

public class NumberHelper
{
    public static bool INumeric(string firstNumber)
    {
        return decimal.TryParse(firstNumber, out _);
    }
}
namespace HelloWorldApi.Services;

public class MathService
{
    public decimal Sum(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber + secondNumber;
    }

    public decimal Sub(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber - secondNumber;
    }
}
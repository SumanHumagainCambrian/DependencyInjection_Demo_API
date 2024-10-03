namespace DependencyInjection_Demo_API.Interfaces
{
    public interface ICalculatorService
    {
        decimal Add(decimal num1, decimal num2);
        decimal Subtract(decimal num1, decimal num2);
        decimal Multiply(decimal num1, decimal num2);
        decimal Divide(decimal num1, decimal num2);
    }
}

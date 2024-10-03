using DependencyInjection_Demo_API.Interfaces;

namespace DependencyInjection_Demo_API.Services
{
    public class CalculatorService : ICalculatorService<decimal>
    {
        public decimal Add(decimal num1, decimal num2)
        {
            decimal sum = num1 + num2;
            return sum;
        }

        public decimal Subtract(decimal num1, decimal num2)
        {
            decimal sub = num1 - num2;
            return sub;
        }

        public decimal Multiply(decimal num1, decimal num2)
        {
            decimal multiplication = num1 * num2;
            return multiplication;
        }

        public decimal Divide(decimal num1, decimal num2)
        {
            decimal divison = num1 / num2;
            return divison;
        }
    }
}

using DependencyInjection_Demo_API.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection_Demo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService<decimal> _calculatorService;

        // Injecting the CalculatorService
        public CalculatorController(ICalculatorService<decimal> calculatorService)
        {
            _calculatorService = calculatorService;
        }

        // GET add action
        [HttpGet("add")]
        public ActionResult<decimal> Add(decimal num1, decimal num2)
        {
            var result = _calculatorService.Add(num1, num2);
            return Ok(result);
        }

        // GET subtract action
        [HttpGet("subtract")]
        public ActionResult<decimal> Subtract(decimal num1, decimal num2)
        {
            var result = _calculatorService.Subtract(num1, num2);
            return Ok(result);
        }

        // GET multiply action
        [HttpGet("multiply")]
        public ActionResult<decimal> Multiply(decimal num1, decimal num2)
        {
            var result = _calculatorService.Multiply(num1, num2);
            return Ok(result);
        }

        // GET divide action
        [HttpGet("divide")]
        public ActionResult<decimal> Divide(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Divide by zero exception.");
            }
            var result = _calculatorService.Divide(num1, num2);
            return Ok(result);
        }
    }
}

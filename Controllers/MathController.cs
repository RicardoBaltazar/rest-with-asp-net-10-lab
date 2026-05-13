using Microsoft.AspNetCore.Mvc;
using HelloWorldApi.Services;
using Utils;

namespace HelloWorldApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MathController : ControllerBase
{
    private readonly MathService _mathService;

    public MathController(MathService mathService)
    {
        _mathService = mathService;
    }

    [HttpGet("sum/{firstNumber}/{secondNumber}")]
    public IActionResult Get(string firstNumber, string secondNumber)
    {
        if(NumberHelper.INumeric(firstNumber) && NumberHelper.INumeric(secondNumber))
        {
            var result = _mathService.Sum(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber));
            return Ok(result.ToString());
        }
        return BadRequest("Invalid input. Please provide numeric values.");
    }

    [HttpGet("sub/{firstNumber}/{secondNumber}")]
    public IActionResult Sub(string firstNumber, string secondNumber)
    {
        if (NumberHelper.INumeric(firstNumber) && NumberHelper.INumeric(secondNumber))
        {
            var result = _mathService.Sub(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber));
            return Ok(result.ToString());
        }
        return BadRequest("Invalid input. Please provide numeric values.");
    }


}
using Microsoft.AspNetCore.Mvc;
using HelloWorldApi.Model;

namespace HelloWorldApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{

    private static long _counter = 0;
    private static readonly string _template = "Hello, {0}!";

    [HttpGet]
    public Greating Get([FromQuery] string name = "World")
    {
        var id = Interlocked.Increment(ref _counter);
        var content = string.Format(_template, name);
        return new Greating(1, content);
    }
}
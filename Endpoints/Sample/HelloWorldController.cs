using Microsoft.AspNetCore.Mvc;

namespace DotnetApiTemplate.WebApi.Endpoints.Sample
{
    [Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    [Route("[action]")]
    public IActionResult SayHello()
    {
        return Ok("Hello, TeamCity from ASP.NET Core API! the 6 Update");
    }
}

}

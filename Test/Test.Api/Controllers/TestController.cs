using Microsoft.AspNetCore.Mvc;

namespace Test.Api.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    [HttpGet("get")]
    public string Get()
    {
        return "Test";
    }
}
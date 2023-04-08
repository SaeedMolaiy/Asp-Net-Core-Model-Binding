using Microsoft.AspNetCore.Mvc;

namespace ASpModelBindings.Controllers;

[ApiController]
[Route("[controller]")]
public class AspExampleController : ControllerBase
{
    public AspExampleController()
    {
    }

    [HttpGet("Get/{id:int}")]
    public IActionResult Get([FromRoute] int id)
    {
        return Ok(id);
    }

    public IActionResult Get([FromHeader(Name = "Token")] string token)
    {
        return Ok(token);
    }

    public IActionResult Get([FromQuery] AspModel aspModel)
    {
        return Ok(aspModel);
    }

    [HttpPost]
    public IActionResult BodyPost([FromBody] AspModel aspModel)
    {
        return Ok(aspModel);
    }

    [HttpPost]
    public IActionResult FormPost([FromForm] AspModel aspModel)
    {
        return Ok(aspModel);
    }

    [HttpPost]
    public IActionResult BindPost([Bind("Name,Age")] AspModel aspModel)
    {
        return Ok(aspModel);
    }

    public class AspModel
    {
    }
}
using Microsoft.AspNetCore.Mvc;

public class Function
{
    [HttpPost("/")]
    public IActionResult Handle([FromBody] dynamic data)
    {
        return new OkObjectResult(new { message = "Hello, world!", input = data });
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Foodmart.Controllers;

public class ErrorController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}
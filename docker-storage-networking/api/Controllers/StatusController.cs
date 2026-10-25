using Microsoft.AspNetCore.Mvc;

namespace StorageNetworking.Api.Controllers;

[ApiController]
[Route("/")]
public class StatusController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new { application = "StorageNetworking.Api", message = "Lilac keyboard", version = 2 });
}

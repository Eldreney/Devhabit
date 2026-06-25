using Microsoft.AspNetCore.Mvc;

namespace DevHabit.Api.Controllers;


[ApiController]
[Route("[controller]")]
internal sealed  class WeatherForcast : ControllerBase
{



    [HttpGet]
    public IActionResult Index()
        => Ok();
    
}

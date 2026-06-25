using Microsoft.AspNetCore.Mvc;

namespace DevHabit.Api.Controllers;

public  class WeatherForcast : ControllerBase
{
    
    
    
    [HttpGet]
    public IActionResult Index()
    {
        return Ok();    
    }
}
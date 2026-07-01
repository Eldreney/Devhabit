using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace DevHabit.Api.Controllers;


[ApiController]
[Route("api/[controller]")]
public class WeatherForcastController : ControllerBase
{



    [HttpGet]
    public IActionResult Index()
        => Ok("OK");
    




}

using Microsoft.AspNetCore.Mvc;
using Ringmaster.Application;

namespace Ringmaster.API.Controllers;

[ApiController]
[Route("api/restaurants")]
public class RestaurantsController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll(IRestaurantsService restaurantsService)
    {
        var restaurants = await restaurantsService.GetAllRestaurants();
        return Ok(restaurants);
    }
}


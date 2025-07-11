using Microsoft.AspNetCore.Mvc;
using Restaurants.Application.Restaurants;

namespace Restaurants.API.Controllers;

[ApiController]
[Route("api/restaurants")]
public class RestaurantsController(IRestaurantsService restaurantsService) : ControllerBase
{
    [HttpGet] 
    public async Task<IActionResult>  GetAll()
    {
        var restaurants =await restaurantsService.GetAllRestaurants();
        return Ok(restaurants);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute]int id)
    {
        var restaurants = await restaurantsService.GetByIdAsync(id);
        if (restaurants is null)
        {
            return NotFound();
        } 
        return Ok(restaurants);
    }


}

using Microsoft.AspNetCore.Mvc;
using FlightApi.Models.Restaurants;
using Interfaces.RestaurantService;

namespace Controllers;
[Route("[controller]")]
[ApiController]
public class RestautantsController : ControllerBase
{
    private readonly IRestaurantService _restautantService;

    public RestautantsController(IRestaurantService restautantService){
        _restautantService = restautantService;
    }

    // GET: Restautants/location?lat=1234&lng=1234
    [HttpGet("location")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Restaurants))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Restaurants>> GetRestautants(string lat, string lng)
    {
        double la, lg;
        bool isLaValid = Double.TryParse(lat, out la);
        bool isLgValid = Double.TryParse(lng, out lg);
        if (!(isLaValid && isLgValid))
            return BadRequest();
        
        if (la < -90 || la > 90)
            return BadRequest();

        if (lg < -180 || lg > 180)
            return BadRequest();

        var restautants = await _restautantService.GetRestautantsByLatLng(lat, lng);
        return restautants;
    }
}
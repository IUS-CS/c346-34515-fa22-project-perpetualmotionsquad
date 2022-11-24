using Microsoft.AspNetCore.Mvc;
using FlightApi.Models.Restaurants;
using Interfaces.RestautantService;


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
        bool isLaNumerical = Double.TryParse(lat, out la);
        bool islgNumerical = Double.TryParse(lng, out lg);
        if (!(isLaNumerical && islgNumerical))
            return BadRequest();

        if (la < -90 || la > 90)
            return BadRequest();

        if (lg < -90 || lg > 90)
            return BadRequest();

        var restaurants = await _restautantService.GetRestaurantsByLatLng(lat, lng);
        return restaurants;
    }
}
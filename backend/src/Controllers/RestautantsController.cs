using Microsoft.AspNetCore.Mvc;
using FlightApi.Models.Restaurants;
using Interfaces.RestautantService;

namespace Controllers;
[Route("[controller]")]
[ApiController]
public class RestautantsController : ControllerBase
{
    private readonly IRestautantService _restautantService;

    public RestautantsController(IRestautantService restautantService){
        _restautantService = restautantService;
    }

    // GET: Restautants/location?lat=1234&lng=1234
    [HttpGet("location")]
    // [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Restautants))]
    // [ProducesResponseType(StatusCodes.Status404NotFound)]
    // [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Restautants>> GetRestautants(string lat, string lng)
    {
        var restautants = await _restautantService.GetRestautantsByLatLng(lat, lng);
        return restautants;
    }
}
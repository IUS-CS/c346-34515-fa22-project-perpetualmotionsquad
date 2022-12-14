using Microsoft.AspNetCore.Mvc;
using FlightApi.Models.GoogleAPI;
using Interfaces.GoogleService;

namespace Controllers;
[Route("[controller]")]
[ApiController]
public class HotelsController : ControllerBase
{
    private readonly IGoogleService _googleService;

    public HotelsController(IGoogleService googleService){
        _googleService = googleService;
    }

    // GET: Hotels/location?lat=1234&lng=1234
    [HttpGet("location")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Place))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Place>> GetRestautants(string lat, string lng)
    {
        if (!isValid(lat, lng))
            return BadRequest();

        var hotels = await _googleService.GetHotelsByLatLng(lat, lng);
        return Ok(hotels);
    }

    private bool isValid(string lat, string lng)
    {
        double la, lg;
        bool isLaValid = Double.TryParse(lat, out la);
        bool isLgValid = Double.TryParse(lng, out lg);
        if (!(isLaValid && isLgValid))
            return false;
        
        if (la < -90 || la > 90)
            return false;

        if (lg < -180 || lg > 180)
            return false; 

        return true;
    }

}
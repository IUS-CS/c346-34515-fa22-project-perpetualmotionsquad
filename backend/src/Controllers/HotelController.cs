using Microsoft.AspNetCore.Mvc;
using FlightApi.Models.Restaurants;
using Interfaces.HotelService;

namespace Controllers;
[Route("[controller]")]
[ApiController]
public class HotelsController : ControllerBase
{
    private readonly IHotelService _hotelService;

    public HotelsController(IHotelService hotelService){
        _hotelService = hotelService;
    }

    // GET: Hotels/location?lat=1234&lng=1234
    [HttpGet("location")]
    // [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Hotel))]
    // [ProducesResponseType(StatusCodes.Status404NotFound)]
    // [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Hotels>> GetRestautants(string lat, string lng)
    {
        var hotels = await _hotelService.GetHotelsByLatLng(lat, lng);
        return hotels;
    }
}
using Microsoft.AspNetCore.Mvc;
using FlightApi.Models;
using Interfaces.FlightService;
using Services.FlightService;
using System.Text.RegularExpressions;

namespace Controllers;
[Route("[controller]")]
[ApiController]
public class FlightsController : ControllerBase
{
    private readonly IFlightService _flightService;

    public FlightsController(IFlightService flightService){
        _flightService = flightService;
    }

    // GET: Flights/flightnumer?flightnumber=1234&date=2022-09-30
    [HttpGet("flightnumber")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Flight>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<List<Flight>>> GetFlight(string flightNumber, string date)
    {
        string pattern = @"^[A-Z]{2}\d{3,4}$"; 
        if (!Regex.IsMatch(flightNumber, pattern, RegexOptions.IgnoreCase))
            return BadRequest();

        var flight = await _flightService.GetFlightFromFlightNumber(flightNumber, date);
        return Ok(flight);
    }


}
using Microsoft.AspNetCore.Mvc;
using FlightApi.Models;
using Interfaces.FlightService;
using System.Text.RegularExpressions;


[Route("[controller]")]
[ApiController]
public class FlightsController : ControllerBase
{
    private readonly IFlightService flightService;

    public FlightsController(IFlightService flightService){
        this.flightService = flightService;
    }

    // GET: Flights/flightnumer?flightnumber=1234&date=2022-09-30
    [HttpGet("flightnumber")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Flight>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<List<Flight>>> GetFlight(string flightNumber, string date)
    {

        string pattern = @"^([A-Z]{2}|[A-Z]\d|\d[A-Z])[1-9](\d{1,3})?$";

        if (!Regex.IsMatch(flightNumber, pattern, RegexOptions.IgnoreCase))
            return BadRequest();

        var flight = await flightService.GetFlightFromFlightNumber(flightNumber, date);

        return Ok(flight);
    }
}
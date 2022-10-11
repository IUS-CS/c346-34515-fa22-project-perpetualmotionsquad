using Microsoft.AspNetCore.Mvc;
using FlightApi.Models;
using Interfaces.FlightService;
using System.Text.RegularExpressions;
using Services.FlightService;


[Route("[controller]")]
[ApiController]
public class FlightsController : ControllerBase
{
    private readonly IFlightService flightService;

    public FlightsController(){
        this.flightService = FlightService.getFlightService();
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

        var flight = await flightService.GetFlightFromFlightNumber(flightNumber, date);

        return Ok(flight);
    }
}
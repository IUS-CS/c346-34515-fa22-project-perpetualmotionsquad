using Microsoft.AspNetCore.Mvc;
using FlightApi.Models;
using Interfaces.FlightService;


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
    public async Task<ActionResult<List<Flight>>> GetFlight(string? flightNumber, string date)
    {
        var flight = await flightService.GetFlightFromFlightNumber(flightNumber, date);
        return flight;
    }

}
using Microsoft.AspNetCore.Mvc;
using FlightApi.Models;
using Interfaces.FlightService;
using Services.FlightService;

namespace Controllers;

[Route("[controller]")]
[ApiController]
public class ArrivalFlightsController : ControllerBase
{
    private readonly IFlightService _flightService;

    public ArrivalFlightsController(IFlightService flightService){
        _flightService = flightService;
    }

    // GET: ArrivalFlights/icao?icao=KSDF&toLoca=2022-10-05T08:00&fromLocal=2022-10-04T20:00
    [HttpGet("icao")]
    public async Task<ActionResult<Flights>> GetFlights(string toLocal, string fromLocal, string icao)
    {
        
        var flights = await _flightService.GetAllArrivalFlights(toLocal, fromLocal, icao);
        return flights;
    }

}
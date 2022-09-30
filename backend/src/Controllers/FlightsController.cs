using Microsoft.AspNetCore.Mvc;
using FlightApi.Models;
using Services.FlightService;


[Route("[controller]")]
[ApiController]
public class FlightsController : ControllerBase
{
    FlightService service = new FlightService();

    // GET: Flights/flightnumer?flightnumber=1234
    [HttpGet("flightnumber")]
    public async Task<ActionResult<Flight>> GetFlight(string? flightnumber)
    {
        var flight = await service.GetFlightFromFlightNumber(flightnumber);
        return flight;
    }

}
using Microsoft.AspNetCore.Mvc;
using FlightApi.Models;
using Services.FlightService;


[Route("[controller]")]
[ApiController]
public class FlightsController : ControllerBase
{
    FlightService service = new FlightService();

    // GET: Flights/flightnumer?flightnumber=1234&date=2022-09-30
    [HttpGet("flightnumber")]
    public async Task<ActionResult<Flight>> GetFlight(string? flightNumber, string date)
    {
        var flight = await service.GetFlightFromFlightNumber(flightNumber, date);
        return flight;
    }

}
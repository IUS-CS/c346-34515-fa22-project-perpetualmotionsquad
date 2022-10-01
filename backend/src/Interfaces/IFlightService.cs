using FlightApi.Models;

namespace Interfaces.FlightService;
public interface IFlightService
{
    public Task<List<Flight>> GetFlightFromFlightNumber(string flightNumber, string date);
}
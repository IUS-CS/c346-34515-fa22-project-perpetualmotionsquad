using FlightApi.Models.Flights;

namespace Interfaces.FlightService;
public interface IFlightService
{
    public Task<List<Flight>> GetFlightFromFlightNumber(string flightNumber, string date);
    public Task<Flights> GetAllArrivalFlights(string toLocal, string fromLocal, string icao);
}
using FlightApi.Models;

namespace Interfaces.ArrivalFlightsService;
public interface IArrivalFlightsService
{
    public Task<Flights> GetAllArrivalFlights(string toLocal, string fromLocal, string icao);
}
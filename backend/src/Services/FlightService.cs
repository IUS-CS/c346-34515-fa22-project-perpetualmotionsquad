using FlightApi.Models;
using System.Net.Http.Headers;
using System.Text.Json;
using Interfaces.FlightService;

namespace Services.FlightService;
using System.Text.Json.Serialization;
public class FlightService:IFlightService
{
    HttpClient client = new HttpClient();
    public FlightService()
    {

        client.DefaultRequestHeaders.Add("X-RapidAPI-Key","");
        client.DefaultRequestHeaders.Add("X-RapidAPI-Host","aerodatabox.p.rapidapi.com");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
    public async Task<List<Flight>> GetFlightFromFlightNumber(string flightNumber, string date)
    {
        var streamTask = client.GetStreamAsync($"https://aerodatabox.p.rapidapi.com/flights/number/{flightNumber}/{date}?withAircraftImage=true&withLocation=true");
        var listOfFlights = await JsonSerializer.DeserializeAsync<List<Flight>>(await streamTask);
        return listOfFlights;
    }


    public async Task<Flights> GetAllArrivalFlights(string toLocal, string fromLocal, string icao)
    {

        var streamTask = client.GetStreamAsync
            ($"https://aerodatabox.p.rapidapi.com/flights/airports/icao/{icao}/{fromLocal}/{toLocal}?withLeg=true&direction=Both&withCancelled=true&withCodeshared=true&withCargo=false&withPrivate=false&withLocation=true");
        var listOfFlights = await JsonSerializer.DeserializeAsync<Flights>(await streamTask);
        return listOfFlights;
    }
}
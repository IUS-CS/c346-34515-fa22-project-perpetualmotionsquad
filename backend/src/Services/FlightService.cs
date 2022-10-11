using FlightApi.Models;
using System.Net.Http.Headers;
using System.Text.Json;
using Interfaces.FlightService;

namespace Services.FlightService;
using System.Text.Json.Serialization;
public class FlightService:IFlightService
{
    private static FlightService flightService;
    HttpClient client = new HttpClient();
    public FlightService()
    {

        client.DefaultRequestHeaders.Add("X-RapidAPI-Key","0e399b4b62msh4365c4f813b9d1bp1fd651jsn33ca5ec4b077");
        client.DefaultRequestHeaders.Add("X-RapidAPI-Host","aerodatabox.p.rapidapi.com");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
    public static FlightService getFlightService()
    {
        if (flightService == null)
            flightService = new FlightService();
        
        return flightService;
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
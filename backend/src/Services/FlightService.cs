using FlightApi.Models;
using System.Net.Http.Headers;
using System.Text.Json;
using Interfaces.FlightService;

namespace Services.FlightService;
public class FlightService:IFlightService
{
    HttpClient client = new HttpClient();
    public async Task<List<Flight>> GetFlightFromFlightNumber(string flightNumber, string date)
    {
        client.DefaultRequestHeaders.Add("X-RapidAPI-Key","");
        client.DefaultRequestHeaders.Add("X-RapidAPI-Host","aerodatabox.p.rapidapi.com");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var streamTask = client.GetStreamAsync($"https://aerodatabox.p.rapidapi.com/flights/number/{flightNumber}/{date}?withAircraftImage=true&withLocation=true");
        var listOfFlights = await JsonSerializer.DeserializeAsync<List<Flight>>(await streamTask);
        return listOfFlights;
    }
}
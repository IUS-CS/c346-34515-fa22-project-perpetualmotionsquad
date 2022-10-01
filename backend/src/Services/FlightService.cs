using FlightApi.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Services.FlightService;
public class FlightService
{
    HttpClient client = new HttpClient();
    public async Task<List<Flight>> GetFlightFromFlightNumber(string flightNumber, string date)
    {
        client.DefaultRequestHeaders.Add("X-RapidAPI-Key","api key");
        client.DefaultRequestHeaders.Add("X-RapidAPI-Host","aerodatabox.p.rapidapi.com");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var streamTask = client.GetStreamAsync($"https://aerodatabox.p.rapidapi.com/flights/number/{flightNumber}/{date}?withAircraftImage=true&withLocation=true");
        var listOfflights = await JsonSerializer.DeserializeAsync<List<Flight>>(await streamTask);
        return listOfflights;
    }
}
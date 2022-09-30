using FlightApi.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Services.FlightService;
public class FlightService
{
    HttpClient client = new HttpClient();
    public async Task<Flight> CallingApiFlight(string s)
    {
        client.DefaultRequestHeaders.Add("X-RapidAPI-Key","0e399b4b62msh4365c4f813b9d1bp1fd651jsn33ca5ec4b077");
        client.DefaultRequestHeaders.Add("X-RapidAPI-Host","aerodatabox.p.rapidapi.com");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        var streamTask = client.GetStreamAsync($"https://aerodatabox.p.rapidapi.com/flights/number/{s}/2022-09-27?withAircraftImage=true&withLocation=true");
        var flight = await JsonSerializer.DeserializeAsync<List<Flight>>(await streamTask);
        return flight[0];
    }
}
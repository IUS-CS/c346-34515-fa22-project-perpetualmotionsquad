using FlightApi.Models;
using System.Net.Http.Headers;
using System.Text.Json;
using Interfaces.ArrivalFlightsService;
using System.Text.Json.Serialization;

namespace Services.ArrivalFlightsService;
public class ArrivalFlightsService : IArrivalFlightsService
{
    HttpClient client = new HttpClient();
    public async Task<Flights> GetAllArrivalFlights(string toLocal, string fromLocal, string icao)
    {
        client.DefaultRequestHeaders.Add("X-RapidAPI-Key","");
        client.DefaultRequestHeaders.Add("X-RapidAPI-Host","aerodatabox.p.rapidapi.com");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


        // Does not work 
        JsonSerializerOptions options = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var streamTask = client.GetStreamAsync
            ($"https://aerodatabox.p.rapidapi.com/flights/airports/icao/{icao}/{fromLocal}/{toLocal}?withLeg=true&direction=Both&withCancelled=true&withCodeshared=true&withCargo=false&withPrivate=false&withLocation=true");
        var listOfFlights = await JsonSerializer.DeserializeAsync<Flights>(await streamTask, options);
        return listOfFlights;
    }
}
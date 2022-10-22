using FlightApi.Models;
using System.Text.RegularExpressions;
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

        client.DefaultRequestHeaders.Add("X-RapidAPI-Key","");
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
    // get list of flights by flight number and date
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

    // Check valid flight number
    public bool flightNumberIsValid(String flightNumber)
     {
        string pattern = @"^[A-Z]{2}\d{3,4}$"; 
         if (!Regex.IsMatch(flightNumber, pattern, RegexOptions.IgnoreCase))
            return false;

        return true;
     }
}
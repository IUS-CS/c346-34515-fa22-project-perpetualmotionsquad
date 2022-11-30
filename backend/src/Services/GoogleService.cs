using FlightApi.Models.GoogleAPI;
using System.Net.Http.Headers;
using System.Text.Json;
using Interfaces.GoogleService;

namespace Services.Google;
public class GoogleService : IGoogleService
{
    HttpClient client = new HttpClient();
    public GoogleService()
    {
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
    
    public async Task<Place> GetRestautantsByLatLng(string lat, string lng)
    {
        var streamTask = client.GetStreamAsync($"https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={lat}%2c{lng}&radius=3000&type=restaurant&key=APIKEY");
        var listOfRestautants= await JsonSerializer.DeserializeAsync<Place>(await streamTask);
        listOfRestautants.Results.Sort(delegate (Result x, Result y)
        {
            return y.Rating.CompareTo(x.Rating);
        });
        return listOfRestautants;
    }

    public async Task<Place> GetHotelsByLatLng(string lat, string lng)
    {
        var streamTask = client.GetStreamAsync($"https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={lat}%2c{lng}&radius=3000&type=lodging&key=APIKEY");
        var listOfHotels= await JsonSerializer.DeserializeAsync<Place>(await streamTask);
        listOfHotels.Results.Sort(delegate (Result x, Result y)
        {
            return y.Rating.CompareTo(x.Rating);
        });
        return listOfHotels;
    }
    
}
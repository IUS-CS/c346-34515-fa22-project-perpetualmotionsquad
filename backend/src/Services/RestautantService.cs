
using FlightApi.Models.Restaurants;
using System.Net.Http.Headers;
using System.Text.Json;
using Interfaces.RestautantService;

namespace Services.Restautant;
public class RestautantService : IRestautantService
{
    HttpClient client = new HttpClient();
    public RestautantService()
    {
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
    
    public async Task<Restautants> GetRestautantsByLatLng(string lat, string lng)
    {
        var streamTask = client.GetStreamAsync($"https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={lat}%2c{lng}&radius=3000&type=restaurant&key=APIKEY");
        var listOfRestautants= await JsonSerializer.DeserializeAsync<Restautants>(await streamTask);
        listOfRestautants.Results.Sort(delegate (Result x, Result y)
        {
            return y.Rating.CompareTo(x.Rating);
        });
        return listOfRestautants;
    }
    
}
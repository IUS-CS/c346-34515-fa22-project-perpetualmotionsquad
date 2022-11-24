
using FlightApi.Models.Restaurants;
using System.Net.Http.Headers;
using System.Text.Json;
using Interfaces.HotelService;

namespace Services.Hotel;
public class HotelService : IHotelService
{
    HttpClient client = new HttpClient();
    public HotelService()
    {
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
    
    public async Task<Hotels> GetHotelsByLatLng(string lat, string lng)
    {
        var streamTask = client.GetStreamAsync($"https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={lat}%2c{lng}&radius=3000&type=lodging&key=APIKEY");
        var listOfHotels= await JsonSerializer.DeserializeAsync<Hotels>(await streamTask);
        listOfHotels.Results.Sort(delegate (Result x, Result y)
        {
            return y.Rating.CompareTo(x.Rating);
        });
        return listOfHotels;
    }
    
}
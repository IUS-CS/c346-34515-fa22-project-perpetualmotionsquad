namespace FlightApi.Models.Restaurants;
using System.Text.Json.Serialization;

public class Viewport 
{
    [JsonPropertyName("northeast")]
    public Northeast? Northeast{get; set;}


    [JsonPropertyName("southwest")]
    public Southwest? Southwest{get; set;}
}
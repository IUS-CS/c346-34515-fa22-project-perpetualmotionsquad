namespace FlightApi.Models.Restaurants;
using System.Text.Json.Serialization;

public class Hotels
{
    [JsonPropertyName("results")]
    public List<Result>? Results {get; set;}
}
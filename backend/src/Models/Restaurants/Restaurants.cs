namespace FlightApi.Models.GoogleAPI;
using System.Text.Json.Serialization;

public class Restaurants
{
    [JsonPropertyName("results")]
    public List<Result>? Results {get; set;}
}
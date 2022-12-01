namespace FlightApi.Models.GoogleAPI;
using System.Text.Json.Serialization;

public class Place
{
    [JsonPropertyName("results")]
    public List<Result>? Results {get; set;}
}
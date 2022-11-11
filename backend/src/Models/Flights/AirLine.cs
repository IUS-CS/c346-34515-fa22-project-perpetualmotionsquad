namespace FlightApi.Models.Flights;
using System.Text.Json.Serialization;
public class Airline
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
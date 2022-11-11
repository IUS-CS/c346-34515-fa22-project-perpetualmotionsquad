namespace FlightApi.Models.Flights;
using System.Text.Json.Serialization;
 public class Location
{
    [JsonPropertyName("lat")]
    public double Lat { get; set; }

    [JsonPropertyName("lon")]
    public double Lon { get; set; }
}
namespace FlightApi.Models;
using System.Text.Json.Serialization;
 public class Location
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lat")]
    public double Lat { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lon")]
    public double Lon { get; set; }
}
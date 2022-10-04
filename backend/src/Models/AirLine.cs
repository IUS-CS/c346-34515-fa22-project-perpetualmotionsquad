namespace FlightApi.Models;
using System.Text.Json.Serialization;
public class Airline
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
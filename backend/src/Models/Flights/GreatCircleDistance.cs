namespace FlightApi.Models.Flights;
using System.Text.Json.Serialization;

public class GreatCircleDistance
{
    [JsonPropertyName("meter")]
    public double Meter { get; set; }

    [JsonPropertyName("km")]
    public double Km { get; set; }

    [JsonPropertyName("mile")]
    public double Mile { get; set; }

    [JsonPropertyName("nm")]
    public double Nm { get; set; }

    [JsonPropertyName("feet")]
    public double Feet { get; set; }
}
namespace FlightApi.Models;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
public class Flight
{
    [JsonPropertyName("greatCircleDistance")]
    public GreatCircleDistance? GreatCircleDistance { get; set; }

    [JsonPropertyName("departure")]
    public Departure? Departure { get; set; }

    [JsonPropertyName("arrival")]
    public Arrival? Arrival { get; set; }

    [JsonPropertyName("lastUpdateUtc")]
    public string? LastUpdatedUtc { get; set; }

    [JsonPropertyName("number")]
    public string? Number { get; set; }

    [JsonPropertyName("callSign")]
    public string? CallSign { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("codeshareStatus")]
    public string? CodeshareStatus { get; set; }

    [JsonPropertyName("isCargo")]
    public bool? IsCargo { get; set; }

    [JsonPropertyName("aircraft")]
    public Aircraft? Aircraft { get; set; }

    [JsonPropertyName("airline")]
    public Airline? Airline { get; set; }
}


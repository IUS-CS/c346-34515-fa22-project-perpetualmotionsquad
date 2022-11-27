using System.Text.Json.Serialization;

namespace FlightApi.Models.GoogleAPI;
 public class PlusCode
{
    [JsonPropertyName("compound_code")]
    public string? compound_code { get; set; }

    [JsonPropertyName("global_code")]
    public string? global_code { get; set; }
}
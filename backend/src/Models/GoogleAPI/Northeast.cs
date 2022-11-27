using System.Text.Json.Serialization;

namespace FlightApi.Models.GoogleAPI;
public class Northeast
{
    [JsonPropertyName("lat")]
    public double Lat {get; set;}


    [JsonPropertyName("lng")]
    public double Lng{get; set;}
}
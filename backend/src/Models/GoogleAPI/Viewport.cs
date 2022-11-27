using System.Text.Json.Serialization;

namespace FlightApi.Models.GoogleAPI;
public class Viewport 
{
    [JsonPropertyName("northeast")]
    public Northeast? Northeast{get; set;}


    [JsonPropertyName("southwest")]
    public Southwest? Southwest{get; set;}
}
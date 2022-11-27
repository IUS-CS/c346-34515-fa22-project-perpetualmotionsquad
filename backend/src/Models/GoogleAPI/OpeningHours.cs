using System.Text.Json.Serialization;


namespace FlightApi.Models.GoogleAPI;
public class OpeningHours 
{
    [JsonPropertyName("open_now")]
    public bool open_now {get; set;}
}
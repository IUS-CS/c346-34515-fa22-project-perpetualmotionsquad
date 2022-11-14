namespace FlightApi.Models.Restaurants;
using System.Text.Json.Serialization;


public class OpeningHours 
{
    [JsonPropertyName("open_now")]
    public bool open_now {get; set;}
}
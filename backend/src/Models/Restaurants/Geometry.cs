namespace FlightApi.Models.Restaurants;
using System.Text.Json.Serialization;


public class Geometry
{
    [JsonPropertyName("location")]
    public Location? Location{get; set;}
    


    [JsonPropertyName("viewport")]
    public Viewport? Viewport{get; set;}
}
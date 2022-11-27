using System.Text.Json.Serialization;


namespace FlightApi.Models.GoogleAPI;
public class Geometry
{
    [JsonPropertyName("location")]
    public Location? Location{get; set;}
    


    [JsonPropertyName("viewport")]
    public Viewport? Viewport{get; set;}
}
using System.Text.Json.Serialization;


namespace FlightApi.Models.GoogleAPI;
public class Location
{
    [JsonPropertyName("lat")]
    public double Lat{get; set;}


    [JsonPropertyName("lng")]
    public double Lng{get; set;}
}
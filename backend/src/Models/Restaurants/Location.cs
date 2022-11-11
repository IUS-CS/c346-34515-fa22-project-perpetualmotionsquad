namespace FlightApi.Models.Restaurants;
using System.Text.Json.Serialization;


public class Location
{
    [JsonPropertyName("lat")]
    public double Lat{get; set;}


    [JsonPropertyName("lng")]
    public double Lng{get; set;}
}
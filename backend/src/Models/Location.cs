namespace FlightApi.Models;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
 public class Location
{
    [JsonPropertyName("lat")]
    public double Lat { get; set; }

    [JsonPropertyName("lon")]
    public double Lon { get; set; }
}
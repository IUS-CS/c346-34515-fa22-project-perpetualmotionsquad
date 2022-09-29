namespace FlightApi.Models;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
public class Airline
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
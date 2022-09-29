namespace FlightApi.Models;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
public class Airport
{

    
    [JsonPropertyName("icao")]
    public string? Icao { get; set; }

    [JsonPropertyName("iata")]
    public string? Iata{get; set;}

    [JsonPropertyName("name")]
    public string? Name {get; set;}

   

    [JsonPropertyName("shortName")]
    public string? ShortName{get; set;}
    
    [JsonPropertyName("municipalityName")]
    public string? MunicipalityName{get; set;}

    [JsonPropertyName("location")]
    public Location Location{get; set;}
    
    [JsonPropertyName("countryCode")]
    public string? CountryCode{get; set;}
}



namespace FlightApi.Models.Restaurants;
using System.Text.Json.Serialization;


public class Photo 
{
    [JsonPropertyName("height")]
    public int height {get; set;}

    [JsonPropertyName("html_attributions")]
    public List<string> html_attributions {get; set;}


    [JsonPropertyName("photo_reference")]
    public string photo_reference{get; set;}



    [JsonPropertyName("width")]
    public int width{get; set;}
}
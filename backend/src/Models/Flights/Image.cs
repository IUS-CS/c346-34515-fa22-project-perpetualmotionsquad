namespace FlightApi.Models.Flights;
using System.Text.Json.Serialization;

 public class Image
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    
    [JsonPropertyName("webUrl")]
    public string? WebUrl { get; set; }

    [JsonPropertyName("author")]
    public string? Author { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("license")]
    public string? License { get; set; }

    [JsonPropertyName("htmlAttributions")]
    public List<string>? HtmlAttributions { get; set; }
}
namespace FlightApi.Models;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
public class Departure
{

    
    [JsonPropertyName("airport")]
    public Airport Airport { get; set; }



    [JsonPropertyName("scheduledTimeLocal")]
    public string ScheduledTimeLocal { get; set; }




    [JsonPropertyName("actualTimeLocal")]
    public string ActualTimeLocal { get; set; }



    [JsonPropertyName("runwayTimeLocal")]
    public string RunwayTimeLocal { get; set; }


    [JsonPropertyName("scheduledTimeUtc")]
    public string ScheduledTimeUtc { get; set; }



    [JsonPropertyName("actualTimeUtc")]
    public string ActualTimeUtc { get; set; }



    [JsonPropertyName("runwayTimeUtc")]
    public string RunwayTimeUtc { get; set; }



    [JsonPropertyName("terminal")]
    public string Terminal { get; set; }



    [JsonPropertyName("quality")]
    public List<string> Quality { get; set; }
}

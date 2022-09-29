namespace FlightApi.Models;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
 public class Aircraft
{

    [JsonPropertyName("reg")]
    public string Reg { get; set; }



    [JsonPropertyName("modeS")]
    public string ModeS { get; set; }

    
    [JsonPropertyName("model")]
    public string Model { get; set; }




    [JsonPropertyName("image")]
    public Image Image { get; set; }
}
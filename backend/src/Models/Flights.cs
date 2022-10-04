
namespace FlightApi.Models;
using System.Text.Json.Serialization;
public class Flights
{
    [JsonPropertyName("arrivals")]
    public List<Flight>? ArrivalFlights { get; set; }
}
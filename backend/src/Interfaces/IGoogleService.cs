
using FlightApi.Models.GoogleAPI;

namespace Interfaces.GoogleService;
public interface IGoogleService
{
    public Task<Place> GetRestautantsByLatLng(string lat, string lng);
    public Task<Place> GetHotelsByLatLng(string lat, string lng);
}
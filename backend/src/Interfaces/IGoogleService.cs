
using FlightApi.Models.GoogleAPI;

namespace Interfaces.GoogleService;
public interface IGoogleService
{
    public Task<Restaurants> GetRestautantsByLatLng(string lat, string lng);
    public Task<Hotels> GetHotelsByLatLng(string lat, string lng);
}
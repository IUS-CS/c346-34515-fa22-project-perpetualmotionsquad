
using FlightApi.Models.Restaurants;

namespace Interfaces.HotelService;
public interface IHotelService
{
    public Task<Hotels> GetHotelsByLatLng(string lat, string lng);
}

using FlightApi.Models.Restaurants;

namespace Interfaces.RestaurantService;
public interface IRestaurantService
{
    public Task<Restaurants> GetRestautantsByLatLng(string lat, string lng);
}
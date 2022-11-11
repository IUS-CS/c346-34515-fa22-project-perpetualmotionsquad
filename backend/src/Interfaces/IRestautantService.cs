
using FlightApi.Models.Restaurants;

namespace Interfaces.RestautantService;
public interface IRestautantService
{
    public Task<Restautants> GetRestautantsByLatLng(string lat, string lng);
}
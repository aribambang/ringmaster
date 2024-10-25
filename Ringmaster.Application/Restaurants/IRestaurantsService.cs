using Ringmaster.Application.Dtos;
using Ringmaster.Application.Restaurants.Dtos;

namespace Ringmaster.Application;

public interface IRestaurantsService
{
    Task<IEnumerable<RestaurantDto>> GetAllRestaurants();
    Task<RestaurantDto?> GetById(int id);
    Task<int> Create(CreateRestaurantDto createRestaurantDto);
}

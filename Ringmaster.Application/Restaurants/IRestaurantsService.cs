using Ringmaster.Application.Dtos;

namespace Ringmaster.Application;

public interface IRestaurantsService
{
    Task<IEnumerable<RestaurantDto>> GetAllRestaurants();
    Task<RestaurantDto?> GetById(int id);
}

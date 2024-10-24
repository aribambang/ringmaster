using Ringmaster.Domain.Entities;

namespace Ringmaster.Application;

public interface IRestaurantsService
{
    Task<IEnumerable<Restaurant>> GetAllRestaurants();
    Task<Restaurant?> GetById(int id);
}

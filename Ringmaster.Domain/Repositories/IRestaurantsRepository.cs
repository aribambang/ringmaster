using Ringmaster.Domain.Entities;

namespace Ringmaster.Domain.Repositories;

public interface IRestaurantsRepository
{
    Task<IEnumerable<Restaurant>> GetAllAsync();
}

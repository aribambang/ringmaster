using Microsoft.EntityFrameworkCore;
using Ringmaster.Domain.Entities;
using Ringmaster.Domain.Repositories;
using Ringmaster.Infrastructure.Persistance;

namespace Ringmaster.Infrastructure.Repositories;

internal class RestaurantsRepository(RestaurantsDBContext dbContext) : IRestaurantsRepository
{
    public async Task<IEnumerable<Restaurant>> GetAllAsync()
    {
        var restaurants = await dbContext.Restaurants.ToListAsync();
        return restaurants;
    }
}

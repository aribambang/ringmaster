using Microsoft.Extensions.Logging;
using Ringmaster.Domain.Entities;
using Ringmaster.Domain.Repositories;

namespace Ringmaster.Application.Restaurants;

internal class RestaurantsService(IRestaurantsRepository restaurantsRepository, ILogger<RestaurantsService> logger) : IRestaurantsService
{
    public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
    {
        logger.LogInformation("Get all restaurants");
        var restaurants = await restaurantsRepository.GetAllAsync();
        return restaurants;
    }

    public async Task<Restaurant?> GetById(int id)
    {
        logger.LogInformation($"Get restaurant {id}");
        var restaurant = await restaurantsRepository.GetByIdAsync(id);

        return restaurant;
    }
}

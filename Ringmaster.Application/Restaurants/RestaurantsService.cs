using AutoMapper;
using Microsoft.Extensions.Logging;
using Ringmaster.Application.Dtos;
using Ringmaster.Domain.Repositories;

namespace Ringmaster.Application.Restaurants;

internal class RestaurantsService(
    IRestaurantsRepository restaurantsRepository,
    ILogger<RestaurantsService> logger,
    IMapper mapper) : IRestaurantsService
{
    public async Task<IEnumerable<RestaurantDto>> GetAllRestaurants()
    {
        logger.LogInformation("Get all restaurants");
        var restaurants = await restaurantsRepository.GetAllAsync();

        var restaurantsDtos = mapper.Map<IEnumerable<RestaurantDto>>(restaurants);
        return restaurantsDtos!;
    }

    public async Task<RestaurantDto?> GetById(int id)
    {
        logger.LogInformation($"Get restaurant {id}");
        var restaurant = await restaurantsRepository.GetByIdAsync(id);
        var restaurantDto = mapper.Map<RestaurantDto?>(restaurant);

        return restaurantDto;
    }
}

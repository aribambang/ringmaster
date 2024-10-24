using System;
using Microsoft.Extensions.DependencyInjection;
using Ringmaster.Application.Restaurants;

namespace Ringmaster.Application.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IRestaurantsService, RestaurantsService>();
    }
}

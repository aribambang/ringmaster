using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ringmaster.Infrastructure.Persistance;
using Ringmaster.Infrastructure.Seeders;

namespace Ringmaster.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("RestaurantsDb");
        services.AddDbContext<RestaurantsDBContext>(options => options.UseNpgsql(connectionString));

        services.AddScoped<IRestaurantSeeder, RestaurantSeeder>();
    }
}

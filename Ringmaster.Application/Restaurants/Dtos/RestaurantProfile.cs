using AutoMapper;
using Ringmaster.Application.Dtos;
using Ringmaster.Domain.Entities;

namespace Ringmaster.Application.Restaurants.Dtos;

public class RestaurantProfile : Profile
{
    public RestaurantProfile()
    {
        CreateMap<CreateRestaurantDto, Restaurant>()
            .ForMember(d => d.Address, opt => opt.MapFrom(src => new Address
            {
                Street = src.Street,
                City = src.City,
                PostalCode = src.PostalCode,
            }));

        CreateMap<Restaurant, RestaurantDto>()
            .ForMember(
                r => r.City,
                opt => opt.MapFrom(src => src.Address == null ? null : src.Address.City)
            )
            .ForMember(
                r => r.Street,
                opt => opt.MapFrom(src => src.Address == null ? null : src.Address.Street)
            )
            .ForMember(
                r => r.PostalCode,
                opt => opt.MapFrom(src => src.Address == null ? null : src.Address.PostalCode)
            )
            .ForMember(
                r => r.Dishes,
                opt => opt.MapFrom(src => src.Dishes)
            );
    }
}

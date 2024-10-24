using AutoMapper;
using Ringmaster.Domain.Entities;

namespace Ringmaster.Application.Dishes.Dtos;

public class DishesProfile : Profile
{
    public DishesProfile()
    {
        CreateMap<Dish, DishDto>();
    }
}

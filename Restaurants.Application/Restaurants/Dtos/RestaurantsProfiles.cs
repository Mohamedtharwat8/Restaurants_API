using AutoMapper;
using Restaurants.Application.Restaurants.Commands.CreateRestaurant;
using Restaurants.Application.Restaurants.Commands.UpdateRestaurant;
using Restaurants.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Restaurants.Dtos
{
    public class RestaurantsProfiles : Profile
    {
        public RestaurantsProfiles()
        {
            CreateMap<CreateRestaurantCommand, Restaurant>().
                ForMember(d => d.Address, opt => opt.MapFrom(
                    src => new Address
                    {
                        City = src.City,
                        PostalCode = src.PostalCode,
                        Street = src.Street
                    }));

            CreateMap<Restaurant, RestaurantDto>().
                ForMember(d => d.City, opt => opt.MapFrom(
                    src => src.Address.City)).
                ForMember(d => d.PostalCode, opt => opt.MapFrom(
                    src => src.Address.PostalCode)).
                ForMember(d => d.Street, opt => opt.MapFrom(
                        src => src.Address.Street));
            CreateMap<UpdateRestaurantCommand, Restaurant>();
        }
    }
}

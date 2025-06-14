﻿using Restaurants.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Domain.Repositories
{
    public interface IRestaurantRepository
    {
        Task<IEnumerable<Restaurant>> GetAllAsync();
        //Task<Restaurant?> GetByIdAsync(Guid id);
        //Task AddAsync(Restaurant restaurant);
        //Task UpdateAsync(Restaurant restaurant);
        //Task DeleteAsync(Guid id);
    }
}

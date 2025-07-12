using Microsoft.Extensions.Logging;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Repositories;

namespace Restaurants.Application.Restaurants
{
    public class RestaurantsService(
        IRestaurantRepository restaurantRepository, 
        ILogger<RestaurantsService> logger) : IRestaurantsService
    {
        public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
        {
            logger.LogInformation("Fetching all restaurants from the repository.");
            var restaurants =await restaurantRepository.GetAllAsync();

            return restaurants;
        }

        public Task<Restaurant> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Restaurant> GetRestaurantById(int id)
        {
            // Validate the input ID
            if (id <= 0)
            {
                throw new ArgumentException("ID must be greater than zero.", nameof(id));
            }

            // Retrieve the restaurant from the repository
            var restaurant = await restaurantRepository.GetByIdAsync(id);

            // Check if the restaurant was found
            if (restaurant == null)
            {
                throw new KeyNotFoundException($"Restaurant with ID {id} not found.");
            }

            return restaurant;
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using FoodAspApplication.Models;

namespace FoodAspApplication.Services {
    public class InMemoryRestaurantData : IRestaurantData {
        List<Restaurant> Restaurants;

        public IEnumerable<Restaurant> GetAll() {
            Restaurants = new List<Restaurant> {
                new Restaurant{ Id = 1, Name = "Hanami"},
                new Restaurant{ Id = 2, Name = "Il Molino"},
                new Restaurant{ Id = 3, Name = "Burger King"}
            };
            return Restaurants.OrderBy(restaurant =>restaurant.Name);
        }
    }
}

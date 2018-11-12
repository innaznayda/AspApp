using System.Collections.Generic;
using FoodAspApplication.Models;

namespace FoodAspApplication.Services {
    public interface IRestaurantData {

        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant newRestaurant);
    }
}

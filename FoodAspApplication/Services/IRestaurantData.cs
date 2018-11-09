using System.Collections.Generic;
using FoodAspApplication.Models;

namespace FoodAspApplication.Services {
    public interface IRestaurantData {

        IEnumerable<Restaurant> GetAll();
    }
}

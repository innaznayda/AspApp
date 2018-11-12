using System.Collections.Generic;
using System.Linq;
using FoodAspApplication.Data;
using FoodAspApplication.Models;

namespace FoodAspApplication.Services {
    public class SqlRestaurantData : IRestaurantData {
        private readonly FoodAspApplicationDbContext Context;

        public SqlRestaurantData(FoodAspApplicationDbContext  context) {
            Context = context;
        }

        public Restaurant Add(Restaurant newRestaurant) {
            Context.Restaurants.Add(newRestaurant);
            Context.SaveChanges();
            return newRestaurant;
        }

        public Restaurant Get(int id) {
            return Context.Restaurants.FirstOrDefault(r=>r.Id==id);
        }

        public IEnumerable<Restaurant> GetAll() {
            return Context.Restaurants.OrderBy(r=>r.Name);
        }
    }
}

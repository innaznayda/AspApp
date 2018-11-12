using Microsoft.AspNetCore.Mvc;
using FoodAspApplication.Services;
using FoodAspApplication.ViewModels;
using FoodAspApplication.Models;

namespace FoodAspApplication.Controllers {
    public class HomeController : Controller {
        private IRestaurantData RestaurantData;
        private IGreeter Greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter) {
            RestaurantData = restaurantData;
            Greeter = greeter;
        }

        public IActionResult Index() {
            var model = new HomeIndexViewModel();
            model.Restaurants = RestaurantData.GetAll();
            model.CurrentMessage = Greeter.GetMessageOfTheDay();
            return View(model);
        }

        public IActionResult Details(int id) {
            var model = RestaurantData.Get(id);
            if (model == null) {
                return RedirectToAction(nameof(Index));

            } else {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditModel restaurant) {
            var newRestaurant = new Restaurant();
            newRestaurant.Name = restaurant.Name;
            newRestaurant.Cuisine = restaurant.Cuisine;

            newRestaurant = RestaurantData.Add(newRestaurant);
            return View("Details", newRestaurant);
        }

    }
}

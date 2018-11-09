using Microsoft.AspNetCore.Mvc;
using FoodAspApplication.Services;

namespace FoodAspApplication.Controllers {
    public class HomeController : Controller {
        public IRestaurantData RestaurantData;

        public HomeController(IRestaurantData restaurantData) {
           RestaurantData = restaurantData;
        }

        

        public IActionResult Index() {

            var model = RestaurantData.GetAll();
            return View(model);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodAspApplication.Models;
using FoodAspApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodAspApplication.Pages.Restaurants {
    public class EditModel : PageModel {
        private readonly IRestaurantData RestaurantData;
        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public EditModel(IRestaurantData restaurantData) {
            RestaurantData = restaurantData;
        }

        public IActionResult OnGet(int id) {
            Restaurant = RestaurantData.Get(id);
            if (Restaurant == null) {
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }

        public IActionResult OnPost() {
            if (ModelState.IsValid) {
                RestaurantData.Update(Restaurant);
                return RedirectToAction("Details", "Home", new { id = Restaurant.Id });
            } else {
                return Page();
            }

        }
    }
}

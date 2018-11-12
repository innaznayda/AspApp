using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodAspApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodAspApplication.Pages {
    public class GreetingModel : PageModel {
        private readonly IGreeter Greeter;
        public string CurretnGreeting { get; set; }

        public GreetingModel(IGreeter greeter) {
            Greeter = greeter;
        }

        public void OnGet() {
            CurretnGreeting = Greeter.GetMessageOfTheDay();
        }
    }
}
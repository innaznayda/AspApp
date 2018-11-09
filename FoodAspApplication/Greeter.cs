using Microsoft.Extensions.Configuration;
using FoodAspApplication.Services;

namespace FoodAspApplication {
    internal class Greeter : IGreeter {
        private IConfiguration Configuration;

        public Greeter(IConfiguration config) {
            Configuration = config;                
        }

        public string GetMessageOfTheDay() {
            return Configuration["Greeting"];
        }
    }
}
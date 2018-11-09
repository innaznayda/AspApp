using Microsoft.Extensions.Configuration;

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
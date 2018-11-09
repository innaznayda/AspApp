using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodAspApplication.Controllers {
    [Route("[controller]")]
    public class AboutController {

        [Route("")]
        public string Phone() {
            return "6537683659643";
        }

        [Route("[action]")]
        public string Adress() {
            return "Kyiv";
        }
    }
}

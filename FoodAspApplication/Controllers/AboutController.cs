using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodAspApplication.Controllers {
    public class AboutController {
        // GET: /<controller>/
        public string Phone() {
            return "6537683659643";
        }

        public string Adress() {
            return "Kyiv";
        }
    }
}

using FoodAspApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodAspApplication.Data {
    public class FoodAspApplicationDbContext : DbContext {

        public FoodAspApplicationDbContext(DbContextOptions options) : base(options) {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

    namespace FoodAspApplication.Models {
    public class Restaurant {
        [Required]
        public int Id { get; set; }

        [Display(Name="Restaurant name ")]
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}

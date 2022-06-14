using System.ComponentModel.DataAnnotations;
using static Car_Renting_System.Data.DataConstants;


namespace Car_Renting_System.Data.Models
{
    public class Car
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(CarBrandMaxLenght)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(CarModelMaxLenght)]
        public string Model { get; set; }

        [Required]
        [MaxLength(CarDescriptionMaxLenght)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }
                
        public int Year { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}

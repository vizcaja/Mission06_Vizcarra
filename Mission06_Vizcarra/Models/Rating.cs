using System.ComponentModel.DataAnnotations;

namespace Mission06_Vizcarra.Models
{
    public class Rating
    {
        public int RatingId { get; set; }

        [Required]
        [MaxLength(5)]
        public string RatingCode { get; set; } = string.Empty; // "G", "PG", "PG-13", "R"

        public List<Movie> Movies { get; set; } = new();
    }
}


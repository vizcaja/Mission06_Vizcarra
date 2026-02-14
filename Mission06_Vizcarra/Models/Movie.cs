using System.ComponentModel.DataAnnotations;

namespace Mission06_Vizcarra.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public string Category { get; set; } = string.Empty;

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Range(1888, 2100)]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; } = string.Empty;

        // Required rating via FK
        [Required]
        public int RatingId { get; set; }
        public Rating? Rating { get; set; }

        // Required yes/no
        [Required]
        public bool Edited { get; set; }

        // Not required
        public string? LentTo { get; set; }

        // Not required + 25 char max
        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}


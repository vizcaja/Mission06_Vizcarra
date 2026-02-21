using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission06_Vizcarra.Models;

public partial class Movie
{
    // Primary key (ID number)
    public int MovieId { get; set; }

    // Foreign key to Category table
    public int? CategoryId { get; set; }

    // =============================
    // REQUIRED FIELDS (Mission 7)
    // =============================

    // Title MUST be entered
    [Required(ErrorMessage = "Please enter a movie title")]
    public string Title { get; set; } = null!;

    // Year MUST be entered AND be 1888 or later
    [Required(ErrorMessage = "Please enter the year")]
    [Range(1888, 3000, ErrorMessage = "Year must be 1888 or later")]
    public int Year { get; set; }

    // Edited MUST be selected
    [Required(ErrorMessage = "Please select if the movie was edited")]
    public int Edited { get; set; }

    // CopiedToPlex MUST be selected
    [Required(ErrorMessage = "Please select if copied to Plex")]
    public int CopiedToPlex { get; set; }

    // =============================
    // OPTIONAL FIELDS
    // =============================

    public string? Director { get; set; }

    public string? Rating { get; set; }

    public string? LentTo { get; set; }

    public string? Notes { get; set; }

    // Navigation property
    public virtual Category? Category { get; set; }
}
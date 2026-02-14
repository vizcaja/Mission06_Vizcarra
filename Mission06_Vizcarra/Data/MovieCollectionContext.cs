using Microsoft.EntityFrameworkCore;
using Mission06_Vizcarra.Models;

namespace Mission06_Vizcarra.Data
{
    public class MovieCollectionContext : DbContext
    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}


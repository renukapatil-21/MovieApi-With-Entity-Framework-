using Microsoft.EntityFrameworkCore;
using MovieApiWithEF.Models;

namespace MovieApiWithEF.EfCore
{
    public class MovieAppDbContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MovieAppDbContext(DbContextOptions<MovieAppDbContext> options) : base(options)
        {

        }
    }
}

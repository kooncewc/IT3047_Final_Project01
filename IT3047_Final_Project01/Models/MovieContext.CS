using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IT3047_Final_Project01.Models;


namespace IT3047_Final_Project01.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        { }

        public DbSet<MovieModel> Movies2 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieModel>().HasData(
                new MovieModel
                {
                    MovieId = 4,
                    Name = "Funny Movie",
                    Year = 2010,
                    Rating = 5,
                },
                new MovieModel
                {
                    MovieId = 2,
                    Name = "Almost funny movie",
                    Year = 2017,
                    Rating = 2,
                },
                new MovieModel
                {
                    MovieId = 3,
                    Name = "Not funny movie",
                    Year = 2010,
                    Rating = 8,
                }
            );

        }
    }
}

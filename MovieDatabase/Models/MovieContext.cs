using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabase.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            //Leave blank for now
        }
        public DbSet<NewMovieResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder nb)
        {
            nb.Entity<NewMovieResponse>().HasData(

                new NewMovieResponse
                {
                    MovieID = 1,
                    Category = "Family",
                    Title = "Despicable Me",
                    Year = 2010,
                    Director = "Pierre Cofflin, Chris Renaud",
                    Rating = "PG"

                },
                new NewMovieResponse
                {
                    MovieID = 2,
                    Category = "Action/Sci-Fi",
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Rating = "PG-13"

                },
                new NewMovieResponse
                {
                    MovieID = 3,
                    Category = "Romance/Comedy",
                    Title = "10 Things I Hate About You",
                    Year = 1999,
                    Director = "Gil Junger",
                    Rating = "PG-13"

                }
                );
        }
    }
}

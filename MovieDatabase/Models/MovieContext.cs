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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder nb)
        {

            nb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName="Action/Adventure"},
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Micellaneous" },
                new Category { CategoryID = 7, CategoryName = "Television" },
                new Category { CategoryID = 8, CategoryName = "VHS" }
            );

            nb.Entity<NewMovieResponse>().HasData(

                new NewMovieResponse
                {
                    MovieID = 1,
                    CategoryID = 4,
                    Title = "Despicable Me",
                    Year = 2010,
                    Director = "Pierre Cofflin, Chris Renaud",
                    Rating = "PG"

                },
                new NewMovieResponse
                {
                    MovieID = 2,
                    CategoryID = 1,
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Rating = "PG-13"

                },
                new NewMovieResponse
                {
                    MovieID = 3,
                    CategoryID = 3,
                    Title = "10 Things I Hate About You",
                    Year = 1999,
                    Director = "Gil Junger",
                    Rating = "PG-13"

                }
                );
        }
    }
}

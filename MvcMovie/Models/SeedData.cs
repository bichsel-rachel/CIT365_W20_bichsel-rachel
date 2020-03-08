using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-9-12"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 4.99M,
                        ImagePath = "~/images/RM.jpg"
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-2-1"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 8.99M,
                        ImagePath = "~/images/Singles-Ward.jpg"
                    },

                    new Movie
                    {
                        Title = "Pride and Prejudice: A Latter-day Comedy",
                        ReleaseDate = DateTime.Parse("2003-12-5"),
                        Genre = "Romance",
                        Rating = "PG",
                        Price = 12.99M,
                        ImagePath = "~/images/Pride-And-Prejudice.jpg"
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Adventure",
                        Rating = "PG",
                        Price = 3.99M,
                        ImagePath = "~/images/17-Miracles.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
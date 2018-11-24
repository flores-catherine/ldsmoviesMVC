using LDSMovies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LDSMoviesContext(
                serviceProvider.GetRequiredService<DbContextOptions<LDSMoviesContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "The R.M.",
                         ReleaseDate = DateTime.Parse("2003-01-31"),
                         Genre = "Comedy",
                     },

                     new Movie
                     {
                         Title = "The Home Teachers ",
                         ReleaseDate = DateTime.Parse("2004-01-11"),
                         Genre = "Comedy",
                     },

                     new Movie
                     {
                         Title = "Church Ball",
                         ReleaseDate = DateTime.Parse("2006-03-17"),
                         Genre = "Comedy",
                     },

                   new Movie
                   {
                       Title = "The Singles 2nd Ward",
                       ReleaseDate = DateTime.Parse("2007-12-11"),
                       Genre = "Comedy",
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
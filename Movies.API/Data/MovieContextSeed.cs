using System;
using System.Collections.Generic;
using System.Linq;
using Movies.API.Model;

namespace Movies.API.Data
{
    public class MovieContextSeed
    {
        public static void SeedAsync(MoviesAPIContext movieContext)
        {
            if (!movieContext.Movie.Any())
            {
                var movies = new List<Movie>
                {
                    new Movie
                    {
                        Id = 1,
                        Genre="Drama",
                        Title="The ShawShank Redemption",
                        Rating = "9.3",
                        ImageURL="image/src",
                        ReleaseDate= new DateTime(1994,5,5),
                        Owner = "Alice"
                    },
                    new Movie
                    {
                        Id = 2,
                        Genre="Crime",
                        Title="The God Father",
                        Rating = "9.2",
                        ImageURL="image/src",
                        ReleaseDate= new DateTime(1992,7,6),
                        Owner = "bob"
                    },
                    new Movie
                    {
                        Id = 3,
                        Genre="Action",
                        Title="The Dark Night",
                        Rating = "9.5",
                        ImageURL="image/src",
                        ReleaseDate= new DateTime(2006,5,2),
                        Owner = "Leo"
                    },
                    new Movie
                    {
                        Id = 4,
                        Genre="BioGraphy",
                        Title="",
                        Rating = "9.0",
                        ImageURL="image/src",
                        ReleaseDate= new DateTime(1972,12,5),
                        Owner = "Mak"
                    }

                };
                movieContext.Movie.AddRange(movies);
                movieContext.SaveChanges();
            }
        }
    }
}

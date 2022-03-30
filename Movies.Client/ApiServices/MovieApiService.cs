using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Movies.Client.Models;

namespace Movies.Client.ApiServices
{
    public class MovieApiService : IMovieApiService
    {
        public Task<Movie> CreateMovie(Movie movie)
        {
             throw new  NotImplementedException();
        }

        public Task DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetMovie(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var moviesList = new List<Movie>();
            moviesList.Add(
                new Movie
                {
                    Id = 1,
                    Genre = "Drama",
                    Title = "The ShawShank Redemption",
                    Rating = "9.3",
                    ImageURL = "image/src",
                    ReleaseDate = new DateTime(1994, 5, 5),
                    Owner = "Alice"

                });

            return await Task.FromResult(moviesList);
        }

        public Task<Movie> UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}

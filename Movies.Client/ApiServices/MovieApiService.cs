using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;
using Movies.Client.Models;
using Newtonsoft.Json;

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
            //1- Get Token from Identity Server
            //2- Send request to protated API
            //3- Deserialized object to movie List

            //1- Get Token from Identity Server
            var apiClientCredential = new ClientCredentialsTokenRequest
            {
                Address = "https://localhost:5005/connect/token",
                ClientId = "movieClient",
                ClientSecret = "secret",
                Scope = "movieAPI"
            };

            //create a new http client to talk to the identity server
            var client = new HttpClient();

            //2-Authenticate and get access token from identity server
            var tokenResponse = await client.RequestClientCredentialsTokenAsync(apiClientCredential);
            if (tokenResponse.IsError)
            {
                return null;
            }


            //2- Send request to protated API
            var apiClient = new HttpClient();

            // set the access token in the request Authorization : Bearer <Token>
            apiClient.SetBearerToken(tokenResponse.AccessToken);

            //Send a request to our protacted API
            var response = await apiClient.GetAsync("https://localhost:5001/api/movies");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            //Deserialized movie object into list

            var movieList = JsonConvert.DeserializeObject<List<Movie>>(content);
            return movieList;
            
        }

           

        public Task<Movie> UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        private static async Task<IEnumerable<Movie>> GetMovieLocal()
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

    }
}

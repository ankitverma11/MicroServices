using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies.Client.Models;

    public class MoviesClientContext : DbContext
    {
        public MoviesClientContext (DbContextOptions<MoviesClientContext> options)
            : base(options)
        {
        }

        public DbSet<Movies.Client.Models.Movie> Movie { get; set; }
    }

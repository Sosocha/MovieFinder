using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieFinder.Model;

namespace MovieFinder.Data
{
    public class MovieFinderContext : DbContext
    {
        public MovieFinderContext (DbContextOptions<MovieFinderContext> options)
            : base(options)
        {
        }

        public DbSet<MovieFinder.Model.Movie> Movie { get; set; }
    }
}

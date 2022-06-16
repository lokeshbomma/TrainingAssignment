using System;


using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCmovies.Models
{
    public class MoviesContext:DbContext
    {
        public MoviesContext() : base("Name=MovieEntites")
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
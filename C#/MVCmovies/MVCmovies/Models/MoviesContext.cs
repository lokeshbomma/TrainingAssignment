using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCmovies.Models
{
    public class Moviescontext:
    {
        public MovieContext() : base("Name=MovieEntites")
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
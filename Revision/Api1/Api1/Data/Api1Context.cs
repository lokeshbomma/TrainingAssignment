using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Api1.Models;

namespace Api1.Data
{
    public class Api1Context : DbContext
    {
        public Api1Context (DbContextOptions<Api1Context> options)
            : base(options)
        {
        }

        public DbSet<Api1.Models.Student> Student { get; set; }
    }
}

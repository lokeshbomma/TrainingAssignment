using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mvc1.Models;

namespace Mvc1.Data
{
    public class Mvc1Context : DbContext
    {
        public Mvc1Context (DbContextOptions<Mvc1Context> options)
            : base(options)
        {
        }

        public DbSet<Mvc1.Models.Customer> Customer { get; set; }
    }
}

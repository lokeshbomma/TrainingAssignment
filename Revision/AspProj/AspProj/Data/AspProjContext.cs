using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspProj.Models;

namespace AspProj.Data
{
    public class AspProjContext : DbContext
    {
        public AspProjContext (DbContextOptions<AspProjContext> options)
            : base(options)
        {
        }

        public DbSet<AspProj.Models.ProdDetail> ProdDetail { get; set; }
    }
}

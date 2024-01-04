using Coffito.Core.Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffito.Core.Service.Context
{
    public class CoffitoDbContext: DbContext
    {
        public CoffitoDbContext(DbContextOptions<CoffitoDbContext> options) : base(options)
        {
        }

        // DbSets
        public DbSet<CoffeeTypes> CoffeeTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Additional configuration
        }
    }
}

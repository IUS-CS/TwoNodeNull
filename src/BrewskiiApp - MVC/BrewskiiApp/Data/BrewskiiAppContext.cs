using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BrewskiiApp.Models
{
    public class BrewskiiAppContext : DbContext
    {
        public BrewskiiAppContext (DbContextOptions<BrewskiiAppContext> options)
            : base(options)
        {
        }

        public DbSet<BrewskiiApp.Models.Beer> Beer { get; set; }
    }
}

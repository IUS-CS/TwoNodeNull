using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Brewskii.Models
{
    public class BrewskiiContext : DbContext
    {
        public BrewskiiContext (DbContextOptions<BrewskiiContext> options)
            : base(options)
        {
        }

        public DbSet<Brewskii.Models.Beer> Beer { get; set; }
    }
}

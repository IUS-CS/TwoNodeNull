using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BrewskiiApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BrewskiiAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<BrewskiiAppContext>>()))
            {
                if (context.Beer.Any())
                {
                    return; //DB has been seeded
                }

                context.Beer.AddRange(
                 
            );
                context.SaveChanges();
            }

        }
    }
}

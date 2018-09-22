using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Brewskii.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BrewskiiContext(serviceProvider.GetRequiredService<DbContextOptions<BrewskiiContext>>()))
            {
                if (context.Beer.Any())
                {
                    return; // DB has been seeded
                }

                context.Beer.AddRange(
                    new Beer
                    {
                        BeerName = "Bud Light",
                        BeerType = "Lager",
                        Price = 0.83M,
                        Rating = 5.0M
                    },

                    new Beer
                    {
                        BeerName = "Sam Adams",
                        BeerType = "Lager",
                        Price = 1.67M,
                        Rating = 4.0M
                    },

                    new Beer
                    {
                        BeerName = "Natural Ice",
                        BeerType = "Unknown",
                        Price = 0.73M,
                        Rating = 0.0M
                    },
                    
                    new Beer
                    {
                        BeerName = "Weihenstephaner Hefe Weiss",
                        BeerType = "Weissbier",
                        Price = 2.17M,
                        Rating = 5.0M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

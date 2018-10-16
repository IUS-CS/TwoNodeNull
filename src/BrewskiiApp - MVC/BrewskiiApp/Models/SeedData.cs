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
                    new Beer
                    {
                        BeerName = "Bud Light",
                        BeerType = "American Light Lager",
                        Rating = 1.86M
                    },
                    new Beer
                    {
                        BeerName = "PBR",
                        BeerType = "American Adjunct Lager",
                        Rating = 2.93M
                    },
                    new Beer
                    {
                        BeerName = "Kentucky Brunch Brand Stout",
                        BeerType = "American Imperial Stout",
                        Rating = 4.84M
                    }
            );
                context.SaveChanges();
            }

        }
    }
}

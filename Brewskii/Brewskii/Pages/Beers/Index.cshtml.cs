using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Brewskii.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Brewskii.Pages.Beers
{
    public class IndexModel : PageModel
    {
        private readonly Brewskii.Models.BrewskiiContext _context;

        public IndexModel(Brewskii.Models.BrewskiiContext context)
        {
            _context = context;
        }

        public IList<Beer> Beer { get;set; }
        public SelectList BeerTypes { get; set; }
        public string BeerType { get; set; }

        public async Task OnGetAsync(string beerType, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> typeQuery = from m in _context.Beer
                                            orderby m.BeerType
                                            select m.BeerType;

            var beers = from m in _context.Beer
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                beers = beers.Where(s => s.BeerName.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(beerType))
            {
                beers = beers.Where(x => x.BeerType == beerType);
            }
            BeerTypes = new SelectList(await typeQuery.Distinct().ToListAsync());
            Beer = await beers.ToListAsync();
        }
    }
}

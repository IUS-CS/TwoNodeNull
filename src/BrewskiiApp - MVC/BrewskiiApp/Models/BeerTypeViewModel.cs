using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrewskiiApp.Models
{
    public class BeerTypeViewModel
    {
        public List<Beer> beers;
        public SelectList beerTypes;
        public string BeerTypes { get; set; }
    }
}

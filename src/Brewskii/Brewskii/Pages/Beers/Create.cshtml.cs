using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Brewskii.Models;

namespace Brewskii.Pages.Beers
{
    public class CreateModel : PageModel
    {
        private readonly Brewskii.Models.BrewskiiContext _context;

        public CreateModel(Brewskii.Models.BrewskiiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Beer Beer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Beer.Add(Beer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}